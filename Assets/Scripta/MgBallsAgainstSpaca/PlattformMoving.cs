using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlattformMoving : MonoBehaviour
{
    private float speedPerSecond = 10f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float movement = Input.GetAxis("Horizontal");
        if (movement != 0.0)
        {
            float speed = speedPerSecond * Time.deltaTime;
            if (!(transform.position.x + (movement * speed) >= 7.5f) && !(transform.position.x + (movement * speed) <= -7.5f))
            {
                Vector2 moveVector = new Vector2(movement, 0);
                moveVector *= speed;
                transform.Translate(moveVector);
            }
        }
    }
}
