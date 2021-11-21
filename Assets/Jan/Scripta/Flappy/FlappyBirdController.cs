using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class FlappyBirdController : MonoBehaviour
{

    public static bool playing = true;
    private Vector3 vel = new Vector3(0, 0, 0);
    public Vector3 jumpSpeed = new Vector3(0, 10, 0);
    public Vector3 gravity = new Vector3(0, -0.01f, 0);
    public float maxVel = 2;
    public static bool lostGame = false;

    public GameObject menu;

    public GameObject[] parts;


    private LinkedList<GameObject> particles = new LinkedList<GameObject>();

    // Start is called before the first frame update

    void OnTriggerEnter2D(Collider2D col)
    {
        playing = false;
    }

    void OnBecameInvisible()
    {
        playing = false;
    }

    void Awake()
    {
        menu.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (playing)
        {
            playerMovement();
            particleMovement();
        }
        else
            Menu();

    }

    void Menu()
    {
        menu.SetActive(true);

        if (Input.GetKeyDown(KeyCode.W) || lostGame)
        {
            Pipes.score = 0;
            //Pipes.text.GetComponent<UnityEngine.UI.Text>().text = " " + Pipes.score;
            Pipes.deleteEverything();
            Vector3 pos = transform.position;
            pos.x = -0.3f;
            pos.y = 0;
            transform.position = pos;
            menu.SetActive(false);
            playing = true;
            lostGame = false;
        }
    }

    void playerMovement()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            spawnParticles();

            if (vel.y < 0)
            {
                Debug.Log("reset");
                vel *= 0;
            }
            vel += jumpSpeed;
        }

        vel += gravity * Time.deltaTime;


        if (vel.magnitude * Time.deltaTime > maxVel * Time.deltaTime)
        {
            vel = vel.normalized * maxVel;
            //Debug.Log("Max");
        }

        transform.rotation = Quaternion.Euler(0f, 0f, velToDegree());
        //Debug.Log(transform.rotation);
        transform.position += vel;
    }

    void particleMovement()
    {
        for (int x = particles.Count - 1; x > -1; x--)
        {
            GameObject p = particles.ElementAt(x);
            p.transform.localScale *= 0.995f;

            if (p.transform.localScale.magnitude < 0.1)
            {
                particles.Remove(p);
                Destroy(p);
            }
        }
    }

    void spawnParticles()
    {
        for (int x = 0; x < 30; x++)
        {
            GameObject particle = Instantiate(parts[x % 3]);
            float offsetx = Random.Range(-100f, 100f);
            float offsety = Random.Range(-100f, 100f);
            particle.transform.position = transform.position;
            particle.GetComponent<Rigidbody2D>().AddForce(new Vector2(-50 + offsetx, 0 + offsety));
            particles.AddLast(particle);
        }
    }
    float velToDegree()
    {
        return map(vel.y, -maxVel, maxVel, -45, 45);
    }

    float map(float s, float a1, float a2, float b1, float b2)
    {
        return b1 + (s - a1) * (b2 - b1) / (a2 - a1);
    }
}

//   <3