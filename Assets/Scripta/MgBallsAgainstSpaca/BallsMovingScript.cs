using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BallsMovingScript : MonoBehaviour
{
    public Sprite firstSprite;
    public Sprite secondSprite;
    public Sprite thirdSprite;
    public Sprite fourthSprite;
    public Sprite fifthSprite;
    private float _speed = 10f;
    public Boolean isOutOfField;
    public Boolean wasDefended;
    public Boolean hasHitted;
    private Vector2 direction;
    // Start is called before the first frame update
    void Start()
    {
        isOutOfField = false;
        wasDefended = false;
        direction = GetDirection();
        Int32 randomNumber = UnityEngine.Random.Range(0,5);
        SpriteRenderer sprity = GetComponent<SpriteRenderer>();
        switch (randomNumber)
        {
            case 0:
                sprity.sprite = firstSprite;
                break;
            case 1:
                sprity.sprite = secondSprite;
                break;
            case 2:
                sprity.sprite = thirdSprite;
                break;
            case 3:
                sprity.sprite = fourthSprite;
                break;
            case 4:
                sprity.sprite = fifthSprite;
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        if(transform.position.y <= -5)
        {
            isOutOfField = true;
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
