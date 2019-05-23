using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    static Text score;

    public void RestartGame()
    {
        SceneManager.LoadScene("Master Level");
        PauseMenu.Reset();
    }

    public void BackToMain()
    {
        PauseMenu.Reset();
        Debug.Log("QUIT!");
        SceneManager.LoadScene("Main Menu");
    }
    /*public void ScoreText()
    {
        //ScoreScript.scoreValue;
    }*/
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
        UpdateScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void UpdateScore()
    {
        score.text = "Score  " + ScoreScript.scoreValue;


    }
}
