using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DefenderBallScript : MonoBehaviour
{
    private Int32 _degrees = 45;
    private Boolean isCurrentlyLeft = true;
    // Start is called before the first frame update
    void Start()
    {
        transform.rotation = Quaternion.Euler(Vector3.forward * _degrees);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            changeSide();
        }
    }

    private void changeSide()
    {
        if(isCurrentlyLeft)
        {
            isCurrentlyLeft = false;
            transform.rotation = Quaternion.Euler(Vector3.forward * -1 * _degrees);
            transform.position += new Vector3(1.5f, 0);
        }
        else
        {
            isCurrentlyLeft = true;
            transform.rotation = Quaternion.Euler(Vector3.forward * _degrees);
            transform.position += new Vector3(-1.5f, 0);
        }
    }
}
