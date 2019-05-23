using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Parralax : MonoBehaviour
{

    [Range(1f, 20f)]

    public float scrollSpeed = 1f;

    public float scrollOffset;

    Vector2 startPos;

    float newPos;

    void Start()
    {
        startPos = transform.position;
    }
    void Update()
    {
        newPos = Mathf.Repeat(Time.time * -scrollSpeed, scrollOffset);
        transform.position = startPos + Vector2.right * newPos;
    }
    /*private float length, startpos;
    public GameObject cam;
    public float parrallaxEffect;
    // Start is called before the first frame update
    void Start()
    {
        startpos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float temp = (cam.transform.position.x * (1 - parrallaxEffect));
        float dist = (cam.transform.position.x * parrallaxEffect);

        transform.position = new Vector3(startpos + dist, 
            transform.position.y, transform.position.z);
        if (temp > startpos + length) startpos += length;
        else if (temp < startpos - length) startpos -= length;
    }*/
}
