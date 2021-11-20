using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    public GameObject gameObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    

    

    
  


// Update is called once per frame
void Update()
    {
        transform.localScale *= 0.99f;
        if (transform.localScale.sqrMagnitude < 0.2) Destroy(gameObject);
    }
}
