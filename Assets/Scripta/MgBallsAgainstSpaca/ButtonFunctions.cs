using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFunctions : MonoBehaviour
{
    public void ChangeScene()
    {
        SceneManager.LoadScene("Scenes/SpaceWaifuScenes/SpaceWaifus");
    }

    public void DoReset()
    {
        GameObject ballWatcher = GameObject.Find("EnemyObjects");
        ballWatcher.GetComponent<BallWatcher>().ResetGame();
    }
}
