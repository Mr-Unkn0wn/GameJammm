using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameRestart : MonoBehaviour
{
    // Start is called before the first frame update
    public void GameRestart()
    {
        Debug.Log("Reloaded a scene");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
