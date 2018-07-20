using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour {

	// Use this for initialization
	void Start () {

        //Sorry it's so slow, wanted to make sure they'd stay on for at least an extra 3 seconds. 

        const float MinImpulseForce = 0.3f;
        const float MaxImpulseForce = 0.5f;

        float angle = Random.Range(0, 2 * Mathf.PI);
        Vector2 direction = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));
        float magnitude = Random.Range(MinImpulseForce, MaxImpulseForce);
        GetComponent<Rigidbody2D>().AddForce(direction * magnitude,ForceMode2D.Impulse);

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag != "Rock")
        {
            Destroy(gameObject);
        }
    }
}
