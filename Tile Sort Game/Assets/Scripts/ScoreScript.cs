using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{

    public static int scoreValue = 0;
    static Text score;

    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text> ();
    }

    public static void SubtractScore(int deduction)
    {
        scoreValue -= deduction;
        Debug.Log("Lost " + deduction + " points");
        UpdateScore();
    }

    public static void AddScore(int addition)
    {
        scoreValue += addition;
        Debug.Log("Gained " + addition + " points");
        UpdateScore();
    }

    public static void UpdateScore()
    {
        score.text = "Score  " + scoreValue;
    }

    // Update is called once per frame
    void Update()
    {
        //No Need to Update Score Every Frame.
        //score.text = "Score: " + scoreValue;
    }
}
