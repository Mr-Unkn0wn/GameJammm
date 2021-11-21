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
        GameObject obj = GameObject.FindGameObjectWithTag("Score");
        Score tmp = obj.GetComponent<Score>();
        if (tmp.score < 15000) SceneManager.LoadScene("MG_YUDINI");
        else SceneManager.LoadScene("SpaceWaifu2");
    }
}
