using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyBirdController : MonoBehaviour
{

    private Vector3 vel = new Vector3(0, 0, 0);
    public Vector3 jumpSpeed = new Vector3(0, 2, 0);
    public Vector3 gravity = new Vector3(0, -0.01f, 0);
    public float maxVel = 2;

    // Start is called before the first frame update


    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("HIT");
    }

    void OnBecameInvisible() {
       // Debug.Log("outside");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)) {
            vel = jumpSpeed;
        }

        vel += gravity * Time.deltaTime;

        if (vel.magnitude > maxVel) {
            vel = vel.normalized * maxVel;
            //Debug.Log("Max");
        }

        transform.rotation = Quaternion.Euler(0f,0f, velToDegree());
        //Debug.Log(transform.rotation);
        transform.position += vel;
    }

    float velToDegree() {
        return map(-vel.magnitude,-maxVel,maxVel,-45,90);
    }

    float map(float s, float a1, float a2, float b1, float b2)
    {
        return b1 + (s - a1) * (b2 - b1) / (a2 - a1);
    }
}
