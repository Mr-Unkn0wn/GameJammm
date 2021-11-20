using System.Collections;
using System.Collections.Generic;
using System.Linq;  
using UnityEngine;

public class Bullets : MonoBehaviour
{

    public float bulletVelocity;
    public GameObject bullet1;
    private float delay;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Fire1") && delay < 0.01)
        {
            delay = 0.3f;
            Vector3 worldMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 direction = (Vector2)((worldMousePos - transform.position));
            direction.Normalize();
            // Creates the bullet locall
            GameObject tmp = Instantiate(bullet1, transform.position + (Vector3)(direction * 0.5f), Quaternion.identity);
            tmp.GetComponent<Rigidbody2D>().velocity = direction * bulletVelocity;
            var dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
            var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            tmp.transform.rotation = Quaternion.AngleAxis(angle + 90, Vector3.forward);
            //tmp.AddComponent<MeshRenderer>();

        }
        else delay -= Time.deltaTime;

    }

    
}
