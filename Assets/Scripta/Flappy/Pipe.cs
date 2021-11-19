using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        BoxCollider2D bo = gameObject.AddComponent<BoxCollider2D>();
        bo.isTrigger = false;


        Rigidbody2D rb = gameObject.AddComponent<Rigidbody2D>();

        rb.gravityScale = 0;
        rb.bodyType = RigidbodyType2D.Dynamic;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
