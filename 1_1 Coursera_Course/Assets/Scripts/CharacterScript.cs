using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScript : MonoBehaviour {

    [SerializeField]
    GameObject pf_Explosion;

    Timer deathTimer;

    [SerializeField]
    float minLifespan = 1;
    [SerializeField]
    float maxLifespan = 2;

    float TeddyBearLifespanSeconds;

	// Use this for initialization
	void Start ()
    {
        // Get a reference to the Timer for death timer
        deathTimer = gameObject.AddComponent<Timer>();
        // Set the Lifespan to be a random int
        TeddyBearLifespanSeconds = Random.Range(minLifespan, maxLifespan);
        //Set the Duration
        deathTimer.Duration = TeddyBearLifespanSeconds;
        //Start the timer
        deathTimer.Run();

        // Used to spawn the bear and send him in a random direction
        const float MinImpulseForce = 3f;
        const float MaxImpulseForce = 5f;
        float angle = Random.Range(0, 2 * Mathf.PI);
        Vector2 direction = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));
        float magnitude = Random.Range(MinImpulseForce, MaxImpulseForce);
        GetComponent<Rigidbody2D>().AddForce(direction * magnitude, ForceMode2D.Impulse);
	}

    //void Update()
    //{
    //    if (deathTimer.Finished)
    //    {
    //        SpawnExplosion();
    //        Destroy(gameObject);
    //    }
    //}
	
    void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.gameObject.tag == "TeddyBear")
        {
            SpawnExplosion();
        }else
        {

            print("ouch!");
        }


    }

    void SpawnExplosion()
    {
        Vector3 location = transform.localPosition;

        GameObject explosion;
        explosion = Instantiate<GameObject>(pf_Explosion, location, Quaternion.identity);
        Destroy(gameObject);
    }
}
