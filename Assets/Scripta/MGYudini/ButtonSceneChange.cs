using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonSceneChange : MonoBehaviour
{
    public void ButtonFunc()
    {
        Debug.Log("kekekek");
        SceneManager.LoadScene("MG_Yudini");
    }
}
