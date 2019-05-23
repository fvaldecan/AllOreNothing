using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject Pausemenu, PauseButton;
    //private bool isPaused;
    public void Start()
    {
        Time.timeScale = 1;
    }
    public void Pause()
    {
        Pausemenu.SetActive(true);
        PauseButton.SetActive(false);
        Time.timeScale = 0;
    }

    public void Resume()
    {
        Pausemenu.SetActive(false);
        PauseButton.SetActive(true);
        Time.timeScale = 1;
    }
    public void MainMenu(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        Reset();
        //Would be a cool feature to set a Text box on the Menu "Highest Score this Run"
    }
    public void Restart()
    {
        Reset();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Resume();
        //Time.timeScale = 1;
    }
    //This function Resets the Game Variables. Easier than copy-pasting the code everywhere
    public static void Reset()
    {
        ScoreScript.scoreValue = 0;
        Gem_Control.CurGemCount = 0;
        Controls.minSpawnTime = 1;
        Controls.maxSpawnTime = 3;
    }
    public void Update()
    {
        if (Input.GetKeyDown("p"))
        {
            Pausemenu.gameObject.SetActive(!Pausemenu.gameObject.activeSelf);
            Pause();
        }
        /*if (Input.GetKeyDown("p"))
        {
          isPaused = !isPaused;
        }
        if (isPaused)
        {
            Pause();
        }
        else
        {
            Resume();
        }*/
    }
}
