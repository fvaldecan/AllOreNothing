using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public int boxChoice = 0;
    public static string leftTag;
    public static string rightTag;
    //Dont forget to update GEMCOUNT when adding new gems.
    const int GEMCOUNT = 6;

    public GameObject plus50, minus100, plus100, minus200,plus150, minus300, 
        plus200, minus400, plus250, minus500, plus300, minus600;
  
    private const float x = 0;
    private const float y = 0;

    /*public AudioSource plusPoints;
    public AudioSource losePoints;*/

    public static bool[] GemSide =  new bool[GEMCOUNT];
    // Destroys objects that collide with it
    void OnTriggerEnter2D(Collider2D collision)
    {
        int GemIndex;
        Debug.Log("Destroyed collided with " + collision.gameObject);

        //Makes adding future gems to the system much easier.
        string GemType = collision.gameObject.GetComponent<SpriteRenderer>().sprite.name;
        switch (GemType)
        {
            case "Purple Heart Gem Plain":
                GemIndex = 1;
                break;
            case "Orange Oval Gem Plain":
                GemIndex = 3;
                break;
            //Best Gem.
            case "Red Circle Gem Plain":
                GemIndex = 5;
                break;
            case "LightBlue Heart Gem Plain":
                GemIndex = 4;
                break;
            case "Green Teardrop Gem Plain":
                GemIndex = 2;
                break;
            //Cheapest Gem
            case "Blue Square Gem Plain":
                GemIndex = 0;
                break;
            default:
                GemIndex = 0;
                break;
        }


        if (this.tag == leftTag)
        {
            //If its false add score, if its true subtract.
            if (!GemSide[GemIndex])
            {
                ScoreScript.AddScore((GemIndex * 50) + 50);
                //Added the switch statement to account for all gem possiblities, tried and failed to move it into Scorescript.
                switch (GemIndex)
                {
                    case 0:
                        SoundManager.PlaySound("plusPoints");
                        Instantiate(plus50, new Vector3(x, y), Quaternion.identity);
                        break;
                    case 1:
                        SoundManager.PlaySound("plusPoints");
                        Instantiate(plus100, new Vector3(x, y), Quaternion.identity);
                        break;
                    case 2:
                        SoundManager.PlaySound("plusPoints");
                        Instantiate(plus150, new Vector3(x, y), Quaternion.identity);
                        break;
                    case 3:
                        SoundManager.PlaySound("plusPoints");
                        Instantiate(plus200, new Vector3(x, y), Quaternion.identity);
                        break;
                    case 4:
                        SoundManager.PlaySound("plusPoints");
                        Instantiate(plus250, new Vector3(x, y), Quaternion.identity);
                        break;
                    case 5:
                        SoundManager.PlaySound("plusPoints");
                        Instantiate(plus300, new Vector3(x, y), Quaternion.identity);
                        break;
                    default:
                        SoundManager.PlaySound("plusPoints");
                        Instantiate(plus50, new Vector3(x, y), Quaternion.identity);
                        break;
                }

            }
            else
            {
                ScoreScript.SubtractScore(2 * ((GemIndex * 50) + 50));
                //Added in text pop-ups to subtract/addscore functions.
                switch (GemIndex)
                {
                    case 0:
                        SoundManager.PlaySound("losePoints");
                        Instantiate(minus100, new Vector3(x, y), Quaternion.identity);
                        break;
                    case 1:
                        SoundManager.PlaySound("losePoints");
                        Instantiate(minus200, new Vector3(x, y), Quaternion.identity);
                        break;
                    case 2:
                        SoundManager.PlaySound("losePoints");
                        Instantiate(minus300, new Vector3(x, y), Quaternion.identity);
                        break;
                    case 3:
                        SoundManager.PlaySound("losePoints");
                        Instantiate(minus400, new Vector3(x, y), Quaternion.identity);
                        break;
                    case 4:
                        SoundManager.PlaySound("losePoints");
                        Instantiate(minus500, new Vector3(x, y), Quaternion.identity);
                        break;
                    case 5:
                        SoundManager.PlaySound("losePoints");
                        Instantiate(minus600, new Vector3(x, y), Quaternion.identity);
                        break;
                    default:
                        SoundManager.PlaySound("losePoints");
                        Instantiate(minus100, new Vector3(x, y), Quaternion.identity);
                        break;
                }
            }
        }
        else if (this.tag == rightTag)
        {
            if (GemSide[GemIndex])
            {
                ScoreScript.AddScore((GemIndex * 50) + 50);
                switch (GemIndex)
                {
                    case 0:
                        SoundManager.PlaySound("plusPoints");
                        Instantiate(plus50, new Vector3(x, y), Quaternion.identity);
                        break;
                    case 1:
                        SoundManager.PlaySound("plusPoints");
                        Instantiate(plus100, new Vector3(x, y), Quaternion.identity);
                        break;
                    case 2:
                        SoundManager.PlaySound("plusPoints");
                        Instantiate(plus150, new Vector3(x, y), Quaternion.identity);
                        break;
                    case 3:
                        SoundManager.PlaySound("plusPoints");
                        Instantiate(plus200, new Vector3(x, y), Quaternion.identity);
                        break;
                    case 4:
                        SoundManager.PlaySound("plusPoints");
                        Instantiate(plus250, new Vector3(x, y), Quaternion.identity);
                        break;
                    case 5:
                        SoundManager.PlaySound("plusPoints");
                        Instantiate(plus300, new Vector3(x, y), Quaternion.identity);
                        break;
                    default:
                        SoundManager.PlaySound("plusPoints");
                        Instantiate(plus50, new Vector3(x, y), Quaternion.identity);
                        break;
                }
            }
            else
            {
                ScoreScript.SubtractScore(2 * ((GemIndex * 50) + 50));
                switch (GemIndex)
                {
                    case 0:
                        SoundManager.PlaySound("losePoints");
                        Instantiate(minus100, new Vector3(x, y), Quaternion.identity);
                        break;
                    case 1:
                        SoundManager.PlaySound("losePoints");
                        Instantiate(minus200, new Vector3(x, y), Quaternion.identity);
                        break;
                    case 2:
                        SoundManager.PlaySound("losePoints");
                        Instantiate(minus300, new Vector3(x, y), Quaternion.identity);
                        break;
                    case 3:
                        SoundManager.PlaySound("losePoints");
                        Instantiate(minus400, new Vector3(x, y), Quaternion.identity);
                        break;
                    case 4:
                        SoundManager.PlaySound("losePoints");
                        Instantiate(minus500, new Vector3(x, y), Quaternion.identity);
                        break;
                    case 5:
                        SoundManager.PlaySound("losePoints");
                        Instantiate(minus600, new Vector3(x, y), Quaternion.identity);
                        break;
                    default:
                        SoundManager.PlaySound("losePoints");
                        Instantiate(minus100, new Vector3(x, y), Quaternion.identity);
                        break;
                }
            }

        }
        Destroy(collision.gameObject);
    }

    public static void GoalSwap()
    {
        for (int i = GEMCOUNT-1; i >= 0; i--)
        {
            GemSideSwap(i);
        }
        //ToDo: Swap The Gem icons once they are implemented
    }
    
    public static void GemSideSwap(int GemIndex)
    {
        //False == left
        //True == right
        GemSide[GemIndex] = !GemSide[GemIndex];
    }
    // Start is called before the first frame update
    void Start()
    {
        leftTag = "leftGoal";
        rightTag = "rightGoal";
        for (int i = GEMCOUNT-1; i >= 0; i--)
        {
            if (i%2 == 0)
                //All Even Gems
                GemSide[i] = true;
            else
                //All Odd index gems
                GemSide[i] = false;
        }

        //plusPoints = GetComponent<AudioSource>();
        //losePoints = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}