using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyParts : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        particleMovement();
    }

    void particleMovement()
    {
        for (int x = particles.Count - 1; x > -1; x--)
        {
            GameObject p = particles.ElementAt(x);
            transform.localScale *= 0.5f;

            if (p.transform.localScale.magnitude < 0.1)
            {
                particles.Remove(p);
                Destroy(p);
            }
        }
    }
}
