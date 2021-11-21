using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Continue : MonoBehaviour
{
    public GameObject lostMenu;
    public Text text;
    public void Contin()
    {
        if (int.Parse(text.text) > 250) SceneManager.LoadScene("");
        else FlappyBirdController.lostGame = true;


       
    }
}
