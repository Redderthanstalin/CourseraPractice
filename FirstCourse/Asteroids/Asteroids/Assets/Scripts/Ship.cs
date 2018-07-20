using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour {

    //Reference to the Rigidbody
    Rigidbody2D rgbd;

    //Vector2 to determine ships direction when adding force
    Vector2 thrustDirection = new Vector2(1, 0);
    float rotationInRadians;

    //Store CircleCollider reference
    CircleCollider2D coll;
    float radius;

    [SerializeField]
    const float ThrustForce = 10.0f;
    [SerializeField]
    const float smallThrusterSpeed = 2.5f;
    [SerializeField]
    const float rotateDegreesPerSecond = 45.0f;

    // Use this for initialization
    void Start () {
        rgbd = gameObject.GetComponent<Rigidbody2D>();
        coll = gameObject.GetComponent<CircleCollider2D>();
        radius = coll.radius;

        Debug.Log("Screen left is: " + ScreenUtils.ScreenLeft);
        

    }
	
	// Update is called once per frame
	void Update ()
    {

        float rotationInput = Input.GetAxis("Rotate");

        if (rotationInput != 0)
        {
            float rotationAmount = rotateDegreesPerSecond * Time.deltaTime;

            //used to check if the input is negative, if it is, turn it around.
            if(rotationInput < 0)
            {
                rotationAmount *= -1;
            }

            //Rotate the Ship
            transform.Rotate(Vector3.forward, rotationAmount);

            //Store the current rotation to get the z value which I need to translate into radians.
            float currentRotationZ = transform.eulerAngles.z;
            //I had to add 90 here because my sprite was originally facing top.
            float rotationInRadians = Mathf.Deg2Rad * (currentRotationZ + 90);

            //Set the new X and Y coordinates with Cos and Sin
            float newX = Mathf.Cos(rotationInRadians);
            float newY = Mathf.Sin(rotationInRadians);

            //Apply new X and Y to the thrustDirection Vector2
            thrustDirection = new Vector2(newX, newY);

        }
	}

    void FixedUpdate()
    {
        if(Input.GetAxis("Thrust") != 0)
        {
            rgbd.AddForce(thrustDirection * ThrustForce, ForceMode2D.Force);
        }
    }

    void OnBecameInvisible()
    {
        Vector2 currentPosition = transform.position;
        float shipRight = ScreenUtils.ScreenRight - radius;
        float shipLeft = ScreenUtils.ScreenLeft - radius;
        float shipTop = ScreenUtils.ScreenTop - radius;
        float shipBottom = ScreenUtils.ScreenBottom - radius;

        if (currentPosition.x > shipRight)
        {
            currentPosition.x = ScreenUtils.ScreenLeft - radius;
            transform.position = currentPosition;
        }
        else if (currentPosition.x < shipLeft)
        {
            currentPosition.x = ScreenUtils.ScreenRight - radius;
            transform.position = currentPosition;
        }
        if (currentPosition.y > shipTop)
        {
            currentPosition.y = ScreenUtils.ScreenBottom + radius;
            transform.position = currentPosition;
        }
        else if(currentPosition.y < shipBottom)
        {
            currentPosition.y = ScreenUtils.ScreenTop + radius;
            transform.position = currentPosition;
        }
    }
}
 