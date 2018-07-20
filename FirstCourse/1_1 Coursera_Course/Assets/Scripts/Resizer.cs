using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resizer : MonoBehaviour {

    // Fields for timer support
    const float TotalResizeSeconds = 1;
    float elapsedResizeSeconds = 0;

    // For Resizing Control
    const float ScaleFactorPerSecond = 1f;
    int scaleFactorSignMultiplier = 1;

	// Update is called once per frame
	void Update ()
    {
        elapsedResizeSeconds += Time.deltaTime;

        // Resize the Sprite
        Vector3 newScale = transform.localScale;
        newScale.x += ScaleFactorPerSecond * scaleFactorSignMultiplier * Time.deltaTime;
        newScale.y += ScaleFactorPerSecond * scaleFactorSignMultiplier * Time.deltaTime;
        transform.localScale = newScale;

        //Update Timer
        if(elapsedResizeSeconds >= TotalResizeSeconds)
        {
            elapsedResizeSeconds = 0;

            if (scaleFactorSignMultiplier == 1) {
                scaleFactorSignMultiplier = -1;
            }
            else
            {
                scaleFactorSignMultiplier = 1;
            }
            
        }
    }
}
