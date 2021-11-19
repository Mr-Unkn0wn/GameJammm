using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class snek : MonoBehaviour
{
    // Start is called before the first frame update
    Vector2 dir = Vector2.right;
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
        transform.Translate(dir);
    }
}
