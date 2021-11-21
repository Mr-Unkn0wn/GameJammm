using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlattformMoving : MonoBehaviour
{
    private float speedPerSecond = 10f;
    private ShowStats statsHolder;

    private void Start()
    {
        statsHolder = GameObject.Find("Statistiks").GetComponent<ShowStats>();
    }

    void Update()
    {
        if (statsHolder.IsGameOver())
        {
            gameObject.SetActive(false);
        }
        else
        {
            if(!gameObject.activeInHierarchy)
            {
                gameObject.SetActive(true);
            }
            float movementHor = Input.GetAxis("Horizontal");
            if (movementHor != 0.0)
            {
                float speed = speedPerSecond * Time.deltaTime;
                if (!(transform.position.x + (movementHor * speed) >= 5.0f) && !(transform.position.x + (movementHor * speed) <= -5.0f))
                {
                    Vector2 moveVector = new Vector2(movementHor, 0);
                    moveVector *= speed;
                    transform.Translate(moveVector);
                }
            }
            float movementVer = Input.GetAxis("Vertical");
            if (movementVer != 0.0)
            {
                float speed = speedPerSecond * Time.deltaTime;
                if (!(transform.position.y + (movementVer * speed) >= -2.0f) && !(transform.position.y + (movementVer * speed) <= -4.0f))
                {
                    Vector2 moveVector = new Vector2(0, movementVer);
                    moveVector *= speed;
                    transform.Translate(moveVector);
                }
            }
        }
    }
}
