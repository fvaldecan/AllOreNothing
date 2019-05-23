using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gem_Control : MonoBehaviour {

    public float maxSpeed = 10f;
    public int numColor = 0;
    public Vector3 clickStart;
    public Rigidbody2D rb;
    public float StartTime;
    public float TimeSinceMouseover;
    public static int CurGemCount = 1;
    private const int MAXGEM = 6;

    //throws gem
    private void ThrowGem()
    {
        rb.velocity = (Input.mousePosition - clickStart);

        // Unneeded if we divide by time. (Physics class, Velocity = Delta-distance/Delta-time)
        if (rb.velocity.magnitude > maxSpeed)
        {
            rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxSpeed);
        }
        Debug.Log("Velocity: " + rb.velocity + "    clickStart: " + clickStart + "  Input.mousePosition: " + Input.mousePosition);
    }

    private void OnMouseUp()
    {
        ThrowGem();
    }

    private void OnMouseDown()
    {
        clickStart = Input.mousePosition;
    }


    // Use this for initialization
    void Start () {
        if (CurGemCount > MAXGEM)
            CurGemCount = MAXGEM;
        rb = GetComponent<Rigidbody2D>();
        TimeSinceMouseover = 0f;
        maxSpeed = 40f;
        numColor = Random.Range(0, CurGemCount);
        // Assigns a color to the box
        switch (numColor)
        {
            case 1:
                this.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Purple Heart Gem Plain");
                break;
            case 3:
                this.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Orange Oval Gem Plain");
                break;
            case 5:
                this.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Red Circle Gem Plain");
                break;
            case 4:
                this.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("LightBlue Heart Gem Plain");
                break;
            case 2:
                this.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Green Teardrop Gem Plain");
                break;
            case 0:
                this.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Blue Square Gem Plain");
                break;
            default:
                this.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Blue Square Gem Plain");
                break;
        }
    }
	
	// Update is called once per frame
	void FixedUpdate () {

        //Gets the world position of the mouse on the screen        
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //Checks whether the mouse is over the sprite
        bool overSprite = this.GetComponent<SpriteRenderer>().bounds.Contains(mousePosition);

        //If it's over the sprite
        if (overSprite)
        {
            //If we've pressed down on the mouse (or touched on the iphone)
            if (Input.GetButton("Fire1"))
            {
                //Debug.Log("moving");
                //Set the position to the mouse position
                this.transform.position = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x,
                    Camera.main.ScreenToWorldPoint(Input.mousePosition).y,
                    0.0f);

                //TimeSinceMouseover = Time.time;
            }
        }


        ////sets click down position
        //if (Input.GetMouseButtonDown(0))
        //    clickStart = Input.mousePosition;


        //if (Input.GetMouseButtonUp(0) && (Time.time - TimeSinceMouseover) < 1)
        //    ThrowGem();

    }
}
