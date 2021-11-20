using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BallsMovingScript : MonoBehaviour
{

    private float _speed = 10f;
    private Boolean goWasGiven;
    public Boolean wasDefended;
    // Start is called before the first frame update
    void Start()
    {
        goWasGiven = false;
        wasDefended = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!goWasGiven)
        {
            goWasGiven = Input.GetKeyDown(KeyCode.H);
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                transform.position = new Vector3(-7.5f, 5f, 0f);
                goWasGiven = false;
            }
            else
            {
                Movement();
            }
        }
    }

    private Vector2 GetDirection()
    {
        GameObject destiny = GameObject.Find("PlayerObjects");
        float xDirection = destiny.transform.position.x - transform.position.x;
        float yDirection = destiny.transform.position.y - transform.position.y;
        Vector2 result = new Vector2(xDirection, yDirection);
        if (result.magnitude < 0.5)
        {
            return new Vector2(0, 0);
        }
        result.Normalize();
        return result;
    }

    private void Movement()
    {
        Vector2 directionVector = GetDirection();
        {
            transform.Translate(directionVector * _speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            wasDefended = true;
        }
    }
}
