using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resizer : MonoBehaviour {

    // Used for timer support
    const float TotalResizeSeconds = 1;
    float elapsedResizeSeconds = 0;

    //Used for resizing control
    public float ScaleFactorPerSecond = 2;
    public int scaleFactorSignMultiplier = -1;


	// Update is called once per frame
	void Update ()
    {
        elapsedResizeSeconds = elapsedResizeSeconds + Time.deltaTime;

        if(elapsedResizeSeconds >= TotalResizeSeconds)
        {
            Vector3 newSpriteScale = transform.localScale;
            newSpriteScale.x = newSpriteScale.x + (ScaleFactorPerSecond * scaleFactorSignMultiplier);
            newSpriteScale.y = newSpriteScale.y + (ScaleFactorPerSecond * scaleFactorSignMultiplier);
            transform.localScale = newSpriteScale;

            elapsedResizeSeconds = 0;
        }
        //Resize the Sprite



    }
}
