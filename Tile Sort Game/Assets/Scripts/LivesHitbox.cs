using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesHitbox : MonoBehaviour
{
    private const float x = (float)5.97;

    private const float y =(float)-10.55;
    public GameObject minusOneLife;
    public GameObject minusOneLogo;
    Rigidbody2D rb;
   
    public void Start()
    {
        //rb = GetComponent<Rigidbody2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        LivesScript.health -= 1;
        SoundManager.PlaySound("loseLife");
        Instantiate(minusOneLife, new Vector3(x, 
            y), Quaternion.identity);
        Destroy(collision.gameObject);
        Instantiate(minusOneLogo, new Vector3(x,
            y), Quaternion.identity);
        Destroy(collision.gameObject);
    }


    /*private Animator animator = null;
    public int SplitCount = 2;
    
    // Start is called before the first frame update
    private void Start()
    {
        animator = GetComponent<Animator>();

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        EdgeCollider2D ec = gameObject.GetComponent<EdgeCollider2D>();
        if (ec != null)
        {
            ec.enabled = false; 
            animator.Play("RedBorder");
            Invoke("ReactiveEdgeCollider", 0.2f);
        }
        LivesScript.health -= 1;
    }
    public void ReactiveEdgeCollider()
    {
        EdgeCollider2D ec = GetComponent<EdgeCollider2D>();
        ec.enabled = true;
    }*/
}
