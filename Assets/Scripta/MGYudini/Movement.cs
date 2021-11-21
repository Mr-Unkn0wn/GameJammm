using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    private Rigidbody2D player;
    private Vector2 playerVelo;


    public Text myText;




    public float speed;

    // Start is called before the first frame update
    void Start()
    {

        player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        playerVelo = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

    }

    private void FixedUpdate()
    {


        player.velocity += playerVelo.normalized * speed - player.velocity * 0.1f;
        if (player.position.x-0.9 < -14 && player.velocity.x < 0) player.velocity = new Vector2(0, player.velocity.y);
        if (player.position.x+0.9 > 14 && player.velocity.x > 0) player.velocity = new Vector2(0, player.velocity.y);
        if (player.position.y-0.9 < -8 && player.velocity.y < 0) player.velocity = new Vector2(player.velocity.x, 0);
        if (player.position.y+0.9 > 8 && player.velocity.y > 0) player.velocity = new Vector2(player.velocity.x, 0);


    }

    public void addPoints(int points)
    {
        myText.text = "" + points;
    }


}
