using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour {


    [SerializeField]
    GameObject Explosion;
    
    const float minForce = 1f;
    const float maxForce = 3f;

    CircleCollider2D coll;
    float radius;

    Rigidbody2D rg2d;

    Vector2 midScreen;

    GameObject hud;
    HUD gameHud;

	// Use this for initialization
	void Start () {

        //Initialize the Rigidbody and Collider and then store the radius
        rg2d = gameObject.GetComponent<Rigidbody2D>();
        coll = gameObject.GetComponent<CircleCollider2D>();
        float radius = coll.radius;
        
        //Store this angle to use as the random variable in the AddForce Direction
        float angle = Random.Range(0, 2 * Mathf.PI);


        float magnitude = Random.Range(minForce, maxForce);

        hud = GameObject.FindGameObjectWithTag("HUD");
        HUD gameHud = hud.GetComponent<HUD>();


        //If the x is not = 0 then it must be the left and right sides
        if (transform.position.x != 0)
        {
            if(transform.position.x > 0)
            {
                midScreen = new Vector2(-1, Mathf.Sin(angle));
            }else
            {
                midScreen = new Vector2(1, Mathf.Sin(angle));

            }
        }
        // If x is == 0 then it must be top and bottom
        else
        {
            if (transform.position.y > 0)
            {
                midScreen = new Vector2(Mathf.Cos(angle), -1);
            }
            else
            {
                midScreen = new Vector2(Mathf.Cos(angle), 1);

            }
        }

        rg2d.AddForce(midScreen * magnitude, ForceMode2D.Impulse);
	}

    //Used for Wrapping
    void OnBecameInvisible()
    {
        Vector2 currentPosition = transform.position;
        float shipRight = ScreenUtils.ScreenRight - radius;
        float shipLeft = ScreenUtils.ScreenLeft - radius;
        float shipTop = ScreenUtils.ScreenTop - radius;
        float shipBottom = ScreenUtils.ScreenBottom - radius;

        if (currentPosition.x > shipRight)
        {
            currentPosition.x = shipLeft;
            transform.position = currentPosition;
        }
        else if (currentPosition.x < shipLeft)
        {
            currentPosition.x = shipRight;
            transform.position = currentPosition;
        }
        if (currentPosition.y > shipTop)
        {
            currentPosition.y = shipBottom;
            transform.position = currentPosition;
        }
        else if (currentPosition.y < shipBottom)
        {
            currentPosition.y = shipTop;
            transform.position = currentPosition;
        }
    }
    //On a Collision, destroy the other game object if it's tag is Player.
    public void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            Destroy(coll.gameObject);
            gameHud.GameTimer = false;
            //Instantiate(Explosion, coll.gameObject.transform.position, Quaternion.identity);
        }
    }
}
