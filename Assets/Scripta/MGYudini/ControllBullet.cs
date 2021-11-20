using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllBullet : MonoBehaviour
{
    private float alive;
    public GameObject objectx;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        alive += Time.deltaTime;
        if (alive > 3) Destroy(objectx);
     
    }
}
