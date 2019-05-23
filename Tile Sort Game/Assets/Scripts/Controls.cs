using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    public Rigidbody2D box;
    public Vector3 boxLocation;
    public float halfHeight ;
    public float halfWidth ;
    public float spawnCountdown;
    public static float minSpawnTime;
    public static float maxSpawnTime;
    public float spawnWidth;
    private static int count;
    //public GameObject[] gems; //sets array of gem objects
    //int randomGem;
    public GameObject blueCart, pinkCart, greenCart, orangeCart, lightblueCart, redCart;
    public GameObject arrow1, arrow2, arrow3, arrow4, arrow5, arrow6;
    public GameObject sideSwap;

    public GameObject blueCart2, pinkCart2, greenCart2, orangeCart2, lightblueCart2, redCart2;
    int gemSpawnNum;
    private const float x = 0;
    private const float y = 0;

    int swapCount = 0;

    //Variables for manipulating spawn-rate (Option 1)
    public const float SPAWNTIMECUTOFF = 0.25f;
	public int NumBoxesUntilIncrease;
	public const float SPAWNTIMEDECREMENT = 0.15f;
	//Option 2 Variables
	public float TimeSinceIncrease;

	// Spawns box
	void SpawnBox()
    {
        boxLocation = new Vector3(Random.Range(-spawnWidth, spawnWidth), halfHeight * 2, 0);
        Instantiate(box, boxLocation, Quaternion.identity);

        //randomGem = Random.Range(0, gems.Length); //animation for gems
        //Instantiate(gems[randomGem], boxLocation, Quaternion.identity);
    }

    // Use this for initialization
    void Start()
    {
        TimeSinceIncrease = 0;
		NumBoxesUntilIncrease = 50; //Rather Low, for testing purposes
        minSpawnTime = 1;
        maxSpawnTime = 3;
        halfHeight = Camera.main.orthographicSize;
        halfWidth = Camera.main.aspect * halfHeight;
        spawnCountdown = Random.Range(minSpawnTime, maxSpawnTime);
        spawnWidth = halfWidth * 4/5;
        gemSpawnNum = 1;
        SpawnIcon();

        count = 0;

    }



    // Update is called once per frame
    void Update()
    {
        // Spawns on timer
        spawnCountdown -= Time.deltaTime;
		TimeSinceIncrease += Time.deltaTime;

        //Option 2: Every X seconds increase the rate at which boxes spawn.
        if (TimeSinceIncrease >= 12) //Good for Linear rate increase
		{

            gemSpawnNum++;
            //Adds a new gem every 12 seconds.
            Gem_Control.CurGemCount++;
            //Every 24 seconds the rate increases
            if (count % 2 == 0)
            {
                if (minSpawnTime > SPAWNTIMECUTOFF)
                {
                    minSpawnTime -= SPAWNTIMEDECREMENT / 2;
                }
                if (maxSpawnTime > maxSpawnTime - SPAWNTIMECUTOFF)
                {
                    maxSpawnTime -= SPAWNTIMEDECREMENT;
                }
            }
            SpawnIcon();
            
            TimeSinceIncrease = 0f;
            Debug.Log("Spawn Rate Increase");
            count++;
            //Swaps a random gem (including those not yet added) every 12 seconds after 24 seconds.
            /*if (count % 2 == 0)
            {
                Goal.GemSideSwap(Random.Range(0, 5));
                Instantiate(sideSwap, new Vector3(x, y), Quaternion.identity);
            }*/
            //Swaps sides every 60 seconds.

            if (count == 5)
            {
                Goal.GoalSwap();
                Instantiate(sideSwap, new Vector3(x, y), Quaternion.identity);
                SwapIcon();
                count = 0;
            }
		}
        //This was called every frame thats why it didnt work.
        /*if (gemSpawnNum == 2)
        {
            Goal.GoalSwap();
            Instantiate(sideSwap, new Vector3(x, y), Quaternion.identity);

        }*/
        if (spawnCountdown < 0)
        {
            SpawnBox();
            Debug.Log("Spawn-Gem");
            spawnCountdown = Random.Range(minSpawnTime, maxSpawnTime);
			//NumBoxesUntilIncrease--;
        }


    }
    void SwapIcon()
    {
        if (swapCount == 0)
        {
            Instantiate(blueCart2, new Vector3(x, y), Quaternion.identity);
            Instantiate(pinkCart2, new Vector3(x, y), Quaternion.identity);
            Instantiate(greenCart2, new Vector3(x, y), Quaternion.identity);
            Instantiate(orangeCart2, new Vector3(x, y), Quaternion.identity);
            Instantiate(lightblueCart2, new Vector3(x, y), Quaternion.identity);
            Instantiate(redCart2, new Vector3(x, y), Quaternion.identity);
            swapCount = 1;
        }
        else
        {
            Instantiate(blueCart, new Vector3(x, y), Quaternion.identity);
            Instantiate(pinkCart, new Vector3(x, y), Quaternion.identity);
            Instantiate(greenCart, new Vector3(x, y), Quaternion.identity);
            Instantiate(orangeCart, new Vector3(x, y), Quaternion.identity);
            Instantiate(lightblueCart, new Vector3(x, y), Quaternion.identity);
            Instantiate(redCart, new Vector3(x, y), Quaternion.identity);
            swapCount = 1;
        }
    }
    void SpawnIcon()
    {
        if (gemSpawnNum == 1)
        {
            Instantiate(blueCart, new Vector3(x, y), Quaternion.identity);
            Instantiate(arrow1, new Vector3(x, y), Quaternion.identity);
        }
        if (gemSpawnNum == 2)
        {
            Instantiate(pinkCart, new Vector3(x, y), Quaternion.identity);
            Instantiate(arrow2, new Vector3(x, y), Quaternion.identity);
        }
        if (gemSpawnNum == 3) 
        {
            Instantiate(greenCart, new Vector3(x, y), Quaternion.identity);
            Instantiate(arrow3, new Vector3(x, y), Quaternion.identity);
        }
        if (gemSpawnNum == 4) 
        {
            Instantiate(orangeCart, new Vector3(x, y), Quaternion.identity);
            Instantiate(arrow4, new Vector3(x, y), Quaternion.identity);
        }
        if (gemSpawnNum == 5)
        {
            Instantiate(lightblueCart, new Vector3(x, y), Quaternion.identity);
            Instantiate(arrow5, new Vector3(x, y), Quaternion.identity);

        }
        if (gemSpawnNum == 6) 
        {
            Instantiate(redCart, new Vector3(x, y), Quaternion.identity);
            Instantiate(arrow6, new Vector3(x, y), Quaternion.identity);


        }

    }
}