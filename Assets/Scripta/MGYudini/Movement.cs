using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D player;
    private Vector2 playerVelo;
   




    public float speed;

    // Start is called before the first frame update
    void Start()
    {   
        
        player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        playerVelo = new Vector2(Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical"));

    }

    private void FixedUpdate()
    {
        player.velocity += playerVelo.normalized*speed - player.velocity*0.1f;
    
    }

 
}
