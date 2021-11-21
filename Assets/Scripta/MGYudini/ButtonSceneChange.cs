using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonSceneChange : MonoBehaviour
{
    public Text text;
    public void ButtonFunc()
    {
        Debug.Log("kekekek");
        SceneManager.LoadScene("MG_Yudini");
    }

    public void goNext()
    {
        if (int.Parse(text.text) < 20000) SceneManager.LoadScene("LoserScene");
        else SceneManager.LoadScene("WinnerScene");
    }
}
