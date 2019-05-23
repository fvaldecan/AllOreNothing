using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemSpawner : MonoBehaviour
{
    private const float GRAVITY = 2.0f;
    public bool IsActive { set; get; }

    private float verticalVelocity;
    private float speed;

    public void LaunchGem(float verticalVelocity,float xSpeed,float xStart)
    {
        IsActive = true;
        speed = xSpeed;
        this.verticalVelocity = verticalVelocity;
        transform.position = new Vector3(xStart, 0, 0);
    }
    private void Update()
    {
        if (!IsActive)
            return;
        verticalVelocity -= GRAVITY * Time.deltaTime;
        transform.position += new Vector3(speed, verticalVelocity, 0) * Time.deltaTime;

        if (transform.position.y < -1)
        {
            IsActive = false;
        }

    }
    /*float maxSpawnRateInSeconds = 5f;
    public GameObject GemGO;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnGem", maxSpawnRateInSeconds);

        InvokeRepeating("IncreasingSpawnRate", 0f, 30f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnGem()
    {
        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));

        Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));

        GameObject gem = (GameObject)Instantiate(GemGO);
        gem.transform.position = new Vector2(Random.Range(min.x, max.x), max.y);


        ScheduleNextGemSpawn();
    }
    void ScheduleNextGemSpawn()
    {
        float spanwInSeconds;
        if (maxSpawnRateInSeconds > 1f)
        {
            spanwInSeconds = Random.Range(1f, maxSpawnRateInSeconds);
        }
        else
            spanwInSeconds = 1f;
        Invoke("SpawnGem", spanwInSeconds);
    }
    void IncreaseSpawnRate()
    {
        if (maxSpawnRateInSeconds > 1f)
            maxSpawnRateInSeconds--;
        if (maxSpawnRateInSeconds == 1f)
            CancelInvoke("IncreaseSpawnRate");
    }*/
}
