using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BallsMovingScript : MonoBehaviour
{

    private float _speed = 10f;
    private Boolean goWasGiven;
    public Boolean wasDefended;
    public Boolean hasHitted;
    private Vector2 direction;
    // Start is called before the first frame update
    void Start()
    {
        goWasGiven = true;
        wasDefended = false;
        direction = GetDirection();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        if(transform.position.y <= -5)
        {
            wasDefended = true;
        }
    }
    

    private Vector2 GetDirection()
    {
        GameObject destiny = GameObject.Find("PlayerObjects");
        float xDirection = (destiny.transform.position.x - transform.position.x) * UnityEngine.Random.value * 2;
        float yDirection = destiny.transform.position.y - transform.position.y * UnityEngine.Random.value * 2;
        Vector2 result = new Vector2(xDirection, yDirection);
        result.Normalize();
        return result;
    }

    private void Movement()
    {
        {
            transform.Translate(direction * _speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            wasDefended = true;
        }
        else if (collision.tag == "SaveZone")
        {
            hasHitted = true;
        }
    }
}
