using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class EnemyMovement : MonoBehaviour
{
   
    private LinkedList<GameObject> particles = new LinkedList<GameObject>();
    private GameObject destiny;
    private static int points;

    public GameObject[] parts;
    public Vector3 forward;
    public float speed;
    public Text myText;
   

    void Start()
    {
        destiny = GameObject.FindGameObjectWithTag("Player");
        
      
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerDest = destiny.transform.position;

        if (GetDistance(playerDest) > 0.3) 
        transform.Translate(Vector3.up * speed * Time.deltaTime);
        
        Vector3 direction = (playerDest - transform.position).normalized;
        forward = direction;


        transform.rotation = Quaternion.FromToRotation(Vector3.up, forward);
    }

    public float GetDistance(Vector3 playerDest)
    {
        float distance = Mathf.Sqrt(Mathf.Pow(playerDest.x - transform.position.x, 2) + Mathf.Pow(playerDest.y - transform.position.y, 2));

        return distance;
    }

    void spawnParticles()
    {
        for (int x = 0; x < 30; x++)
        {
            GameObject particle = Instantiate(parts[x % 3]);
            float offsetx = Random.Range(-300f, 300f);
            float offsety = Random.Range(-300f, 300f);
            particle.transform.position = transform.position;
            particle.GetComponent<Rigidbody2D>().AddForce(new Vector2(-50 + offsetx, 0 + offsety));
            particles.AddLast(particle);
        }
    }
  
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag != "Player")
        {
            points += 200;
            myText.text = "" + points;
            spawnParticles();
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        else
        {
            
        }
       
    }



}
