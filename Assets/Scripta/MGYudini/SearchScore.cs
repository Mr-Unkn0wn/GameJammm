using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SearchScore : MonoBehaviour

    
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject obj = GameObject.FindGameObjectWithTag("Score");
        Score tmp=obj.GetComponent<Score>();
        gameObject.GetComponent<Text>().text = "" + tmp.score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
