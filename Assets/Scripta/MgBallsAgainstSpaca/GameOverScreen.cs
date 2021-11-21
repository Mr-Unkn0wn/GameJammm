using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GameOverScreen : MonoBehaviour
{

    public Text scoreText;

    public Boolean IsActive()
    {
        return gameObject.activeInHierarchy;
    }

    public void SetUp(int score)
    {
        gameObject.SetActive(true);
        scoreText.text = "Score : " + score;
    }
}
