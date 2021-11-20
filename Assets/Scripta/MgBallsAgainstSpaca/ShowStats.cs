using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ShowStats : MonoBehaviour
{
    public Sprite notSoFullHeart;
    public Sprite fullHeart;
    private Int32 currentShownLifes;
    private Int32 score;
    private Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = GameObject.Find("ScoreText").GetComponent<Text>();
        currentShownLifes = 5;
        score = 0;
        for (int i = 0; i < transform.childCount; i++)
        {
            if (transform.GetChild(i).tag == "Health")
            {
                transform.GetChild(i).GetComponent<SpriteRenderer>().sprite = fullHeart;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score : " + score; 
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

    public void ScoreUp()
    {
        score++;
    }

    public Boolean IsGameOver() => currentShownLifes < 1;
}
