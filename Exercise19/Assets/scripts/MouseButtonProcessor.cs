using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Processes mouse button inputs
/// </summary>
public class MouseButtonProcessor : MonoBehaviour
{
    [SerializeField]
    GameObject prefabExplosion;
    [SerializeField]
    GameObject prefabTeddyBear;

    // first frame input support
    bool spawnInputOnPreviousFrame = false;
	bool explodeInputOnPreviousFrame = false;

	/// <summary>
	/// Update is called once per frame
	/// </summary>
	void Update()
	{
        // spawn teddy bear as appropriate
        if (Input.GetAxis("SpawnTeddyBear") > 0)
        {
            if (!spawnInputOnPreviousFrame)
            {
                //Get the position of the mouse
                Vector3 position = Input.mousePosition;
                position.z = -Camera.main.transform.position.z;
                position = Camera.main.ScreenToWorldPoint(position);
                //Spawn the teddy bear
                GameObject teddyBear = Instantiate<GameObject>(prefabTeddyBear, position, Quaternion.identity);
                //Set this bool to true so it doens't spawn 2
                spawnInputOnPreviousFrame = true;
            }

        }else
        {
            spawnInputOnPreviousFrame = false;
        }
        // explode teddy bear as appropriate
		if(Input.GetAxis("ExplodeTeddyBear") > 0)
        {
            if (!explodeInputOnPreviousFrame)
            {
                GameObject teddyBearTarget = GameObject.FindGameObjectWithTag("TeddyBear");
                if(teddyBearTarget != null)
                {
                    GameObject explosion = Instantiate<GameObject>(prefabExplosion, teddyBearTarget.transform.position, Quaternion.identity);
                    Destroy(teddyBearTarget);
                    explodeInputOnPreviousFrame = true;
                }
            }
        }
        else
        {
            explodeInputOnPreviousFrame = false;
        }
	}
}
