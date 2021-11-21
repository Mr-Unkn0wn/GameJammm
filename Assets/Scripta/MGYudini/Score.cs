using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Score : MonoBehaviour
{
    public int score;

    private void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }


}
