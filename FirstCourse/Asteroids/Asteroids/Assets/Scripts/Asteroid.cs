using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour {

    const float minForce = 1f;
    const float maxForce = 3f;

    CircleCollider2D coll;
    float radius;

    Rigidbody2D rg2d;

    Vector2 midScreen;

	// Use this for initialization
	void Start () {
        midScreen = new Vector2(((ScreenUtils.ScreenLeft - ScreenUtils.ScreenRight) / 2), ((ScreenUtils.ScreenBottom - ScreenUtils.ScreenTop) / 2));

        rg2d = gameObject.GetComponent<Rigidbody2D>();
        coll = gameObject.GetComponent<CircleCollider2D>();
        float radius = coll.radius;

        float angle = Random.Range(0, 2 * Mathf.PI);
        //Vector2 direction = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));
        float magnitude = Random.Range(minForce, maxForce);

        if (transform.position.x != 0)
        {
            if(transform.position.x > 0)
            {
                midScreen = new Vector2(-1, 0);
            }else
            {
                midScreen = new Vector2(1, 0);

            }
        }
        else
        {
            if (transform.position.y > 0)
            {
                midScreen = new Vector2(0, -1);
            }
            else
            {
                midScreen = new Vector2(0, 1);

            }
        }

        rg2d.AddForce(midScreen * magnitude, ForceMode2D.Impulse);
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
        else if (currentPosition.y < shipBottom)
        {
            currentPosition.y = ScreenUtils.ScreenTop + radius;
            transform.position = currentPosition;
        }
    }

    public void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            Destroy(coll.gameObject);
        }
    }
}
