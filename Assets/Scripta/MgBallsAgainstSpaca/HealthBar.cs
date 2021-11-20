using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class HealthBar : MonoBehaviour
{
    public Sprite notSoFullHeart;
    public Sprite fullHeart;
    Int32 currentShownLifes;
    // Start is called before the first frame update
    void Start()
    {
        currentShownLifes = 5;
        for(int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).GetComponent<SpriteRenderer>().sprite = fullHeart;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TakeLife()
    {
        SpriteRenderer sprity;
        switch (currentShownLifes)
        {
            case 5:
                sprity = GameObject.Find("Heart5").GetComponent<SpriteRenderer>();
                break;
            case 4:
                sprity = GameObject.Find("Heart4").GetComponent<SpriteRenderer>();
                break;
            case 3:
                sprity = GameObject.Find("Heart3").GetComponent<SpriteRenderer>();
                break;
            case 2:
                sprity = GameObject.Find("Heart2").GetComponent<SpriteRenderer>();
                break;
            case 1:
                sprity = GameObject.Find("Heart1").GetComponent<SpriteRenderer>();
                break;
            default:
                return;
        }
        sprity.sprite = notSoFullHeart;
        currentShownLifes--;
    }
}
