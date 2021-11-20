using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameHandler: MonoBehaviour
{

    public static int PlayerStat;

    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;

    private bool escCooldown = false;

    // Start is called before the first frame update
    void Start()
    {
        pauseMenuUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("escape") && (!escCooldown))
        {
          //  escCooldown = true;
          //  Invoke("ResetEscCooldown", 1.0f);
          //StartCoroutine(Cooldown());
            if (GameIsPaused)
            {
              //  Resume();
            }
            else
            {
                Pause();
            }
            //Application.Quit();
        }
    }

    IEnumerator Cooldown()
    {
        escCooldown = true;
        yield return new WaitForSeconds(1);
        escCooldown = false;
    }
    void ResetEscCooldown()
    {
        escCooldown = false;
    }
    
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void UpdatePlayerStat(int amount)
    {
        PlayerStat += amount;
        Debug.Log("Current Player Stat 0 = " + PlayerStat);
    }

    public int CheckPlayerStat()
    {
        return PlayerStat;
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Scenes/SpaceWaifuScenes/SpaceWaifus");
    }

    public void RestartGame()
    {
        GameIsPaused = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #else
        Application.Quit();
        #endif
    }

}
