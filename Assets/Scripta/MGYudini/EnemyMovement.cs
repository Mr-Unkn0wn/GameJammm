using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public GameObject destiny;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.FromToRotation(transform.position, destiny.transform.position);
        transform.Translate(GetDirection() * Time.deltaTime, 0);
    }

    private Vector2 GetDirection() 
    { 
  

        float xDirection = destiny.transform.position.x - transform.position.x; 
        float yDirection = destiny.transform.position.y - transform.position.y;
        
        Vector2 result = new Vector3(xDirection, yDirection,0); 
        if (result.magnitude < 0.5) 
        {
            return new Vector3(0, 0); 
        } 
   
        return result.normalized; 
    }

}
