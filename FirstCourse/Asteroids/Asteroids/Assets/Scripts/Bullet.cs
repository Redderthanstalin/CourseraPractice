using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    [SerializeField]
    int damage;

    float magnitude = 10f;
    float lifeSpan = 2f;

    [SerializeField]
    GameObject prefabExplosion;
    [SerializeField]
    GameObject asteroid;

    GameObject newAsteroid1;
    GameObject newAsteroid2;

    Timer deathTimer;

    public int Damage
    {
         get { return damage; }
    }

    void Awake()
    {
        
    }

    void Start()
    {
        deathTimer = gameObject.AddComponent<Timer>();

        deathTimer.Duration = lifeSpan;
        deathTimer.Run();
    }

    void Update()
    {
        if (deathTimer.Finished)
        {
            Destroy(gameObject);
        }
    }

    public void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.transform.localScale == new Vector3(0.5f, 0.5f, 0.5f))
        {
            
            Destroy(coll.gameObject);
            Destroy(this.gameObject);
            
        }
        else
        {
            Sprite sprite = coll.gameObject.GetComponent<SpriteRenderer>().sprite;
            Destroy(coll.gameObject);
            Destroy(this.gameObject);
            newAsteroid1 = Instantiate(asteroid, transform.position, transform.rotation);
            newAsteroid1.GetComponent<SpriteRenderer>().sprite = sprite;
            newAsteroid1.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            newAsteroid2 = Instantiate(asteroid, transform.position, transform.rotation);
            newAsteroid2.GetComponent<SpriteRenderer>().sprite = sprite;
            newAsteroid2.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        }


    }

    public void Shoot(Vector2 position)
    {
        Rigidbody2D rb2d = GetComponent<Rigidbody2D>();
        rb2d.AddForce(position * magnitude, ForceMode2D.Impulse);
    }

    //Used for Wrapping
    void OnBecameInvisible()
    {
        BoxCollider2D coll = gameObject.GetComponent<BoxCollider2D>();
        float halfCollWidth = coll.size.x / 2;
        float halfCollHeight = coll.size.y / 2;

        Vector2 currentPosition = transform.position;
        float shipRight = ScreenUtils.ScreenRight - halfCollWidth;
        float shipLeft = ScreenUtils.ScreenLeft - halfCollHeight;
        float shipTop = ScreenUtils.ScreenTop - halfCollWidth;
        float shipBottom = ScreenUtils.ScreenBottom - halfCollHeight;

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
}
