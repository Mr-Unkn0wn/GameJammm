using System.Collections;
//these two are important for the tail algo to work
using System.Collections.Generic;
using System.Linq;
//-------------------------------------
using UnityEngine;

public class snek : MonoBehaviour
{
    // Start is called before the first frame update
    Vector2 dir = Vector2.right;
    List<Transform> tail = new List<Transform>();
    bool ate = false;
    public GameObject tailPrefab;
    void Start()
    {
        InvokeRepeating("Move", 0.3f, 0.3f);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow))
        {
            dir = Vector2.right;
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            dir = -Vector2.right;
        }
        if(Input.GetKey(KeyCode.UpArrow))
        {
            dir = Vector2.up;
        }
        if(Input.GetKey(KeyCode.DownArrow))
        {
            dir = -Vector2.up;
        }
    }

    void Move()
    {   
        //saves current pos in order to make a gap
        Vector2 currentPos = transform.position;
        //moves head to new pos
        transform.Translate(dir);

        if (ate)
        {
            GameObject gameObject = (GameObject) Instantiate(tailPrefab, currentPos, Quaternion.identity);

            tail.Insert(0, gameObject.transform);

            ate = false;
        }

        else if (tail.Count > 0)
        {
            //move last tail to the prev pos of head
            tail.Last().position = currentPos;
            
            //queue fron, pop tail
            tail.Insert(0, tail.Last());
            tail.RemoveAt(tail.Count - 1);
        }
    }

    void OnTriggerEnter2D(Collider2D coll) {
        if (coll.name.StartsWith("foodiePrefub")) {
            ate = true;
            
            Destroy(coll.gameObject);

            Debug.Log("supposed to collide with the prefab");
        }
        // Collided with Tail or Border
        else {
            // ToDo 'You lose' screen
            Debug.Log("AAAAAAAAAAAAAAAAAAAAA");
        }
    }
}
