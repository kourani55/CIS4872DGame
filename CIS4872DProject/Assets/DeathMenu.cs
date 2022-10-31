using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject deathMenuUI;
    public GameObject player;

    private void Start()
    {
        pauseMenuUI.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene("Kirk Scene");
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        player.SetActive(true);
        GameIsPaused = false;


    }

    void Pause()
    {
        deathMenuUI.SetActive(true);
        Time.timeScale = 0f;
        player.SetActive(false);
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
