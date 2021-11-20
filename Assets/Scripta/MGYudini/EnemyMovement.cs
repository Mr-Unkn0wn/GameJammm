using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public GameObject destiny;
    public Vector3 forward;
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerDest = destiny.transform.position;

        if (GetDistance(playerDest) > 0.3) 
        transform.Translate(Vector3.up * speed * Time.deltaTime);
        
        Vector3 direction = (playerDest - transform.position).normalized;
        forward = direction;



        transform.rotation = Quaternion.FromToRotation(Vector3.up, forward);
    }

    public float GetDistance(Vector3 playerDest)
    {
        float distance = Mathf.Sqrt(Mathf.Pow(playerDest.x - transform.position.x, 2) + Mathf.Pow(playerDest.y - transform.position.y, 2));

        return distance;
    }



}
