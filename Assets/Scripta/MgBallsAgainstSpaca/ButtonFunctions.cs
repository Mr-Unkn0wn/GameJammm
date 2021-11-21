using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFunctions : MonoBehaviour
{
    public void ChangeScene()
    {
        if (GameObject.Find("Statistiks").GetComponent<ShowStats>().GetScore() >= 5)
        {
            SceneManager.LoadScene("SpaceWaifu4");
        }
        else
        {
            DoReset();
        }
    }

    public void DoReset()
    {
        GameObject ballWatcher = GameObject.Find("EnemyObjects");
        ballWatcher.GetComponent<BallWatcher>().ResetGame();
    }
}
