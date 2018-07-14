using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour {

    // jump location support

    const float minX = -5.54f;
    const float maxX = 5.54f;
    const float minY = -2.6f;
    const float maxY = 2.6f;

    // timer support
    const float TotalJumpDelaySeconds = 0.1f;

    float elapsedJumpDelaySeconds = 0;
	
    
	// Update is called once per frame
	void Update () {
        // update timer and check if it's done
        elapsedJumpDelaySeconds += Time.deltaTime;

        if(elapsedJumpDelaySeconds >= TotalJumpDelaySeconds)
        {
            elapsedJumpDelaySeconds = 0;

            Vector3 randomPosition = new Vector3();

            randomPosition.x = Random.Range(minX, maxX);
            randomPosition.y = Random.Range(minY, maxY);

            transform.position = randomPosition;
        }
        print(elapsedJumpDelaySeconds);
    }
}
