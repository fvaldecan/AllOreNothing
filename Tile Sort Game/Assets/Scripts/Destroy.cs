using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{

    // Destroys objects that collide with it
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Destroyed collided with " + collision.gameObject);
        //destroys collided object
        Destroy(collision.gameObject);

        // if lives are more than 0 then subtract one
        /*if(LivesScript.livesValue >= 0)
        {
            Debug.Log("Lost a life from Destroy Class");
            LivesScript.SubtractLife();
        }
        else
        {
            //creates game over state
        }*/

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
