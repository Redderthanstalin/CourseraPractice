using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncyBall : MonoBehaviour {

    int health = 100;

    Rigidbody2D rb2d;
    Vector2 direction;
    SpriteRenderer sprite;
    Color tmp;

    HUD hud;

    AudioSource audioSource;

    public int Health
    {
        get { return health; }

    }

    void Start()
    {
        direction = new Vector2(Random.Range(-10.0f, 10.0f), Random.Range(-10.0f, 10.0f));
        rb2d = gameObject.GetComponent<Rigidbody2D>();
        sprite = gameObject.GetComponent<SpriteRenderer>();
        Color tmp = sprite.color;

        hud = GameObject.FindGameObjectWithTag("HUD").GetComponent<HUD>();

        audioSource = GetComponent<AudioSource>();

        rb2d.AddForce(direction, ForceMode2D.Impulse);
    }

    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        health -= 10;
        tmp = sprite.color;
        tmp.a = tmp.a - 0.1f;
        sprite.color = tmp;
        hud.AddPoints(1);
        audioSource.Play();
    }

    
}
