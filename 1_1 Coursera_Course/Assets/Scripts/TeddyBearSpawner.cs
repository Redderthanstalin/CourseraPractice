using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeddyBearSpawner : MonoBehaviour
{
    // Reference to the prefabs I want to spawn
    [SerializeField]
    GameObject pf_YellowBear;
    [SerializeField]
    GameObject pf_GreenBear;
    [SerializeField]
    GameObject pf_PurpleBear;

    // spawn control
    const float MinSpawnDelay = 1;
    const float MaxSpawnDelay = 2;
    Timer spawnTimer;

    //Spawn location support
    const int SpawnBorderSize = 100;
    int minSpawnX;
    int maxSpawnX;
    int minSpawnY;
    int maxSpawnY;





    // Use this for initialization
    void Start () {

        // save spawn boundaries for efficieny
        minSpawnX = SpawnBorderSize;
        maxSpawnX = Screen.width - SpawnBorderSize;
        minSpawnY = SpawnBorderSize;
        maxSpawnY = Screen.height - SpawnBorderSize;

        // create and spawn timer
        spawnTimer = gameObject.AddComponent<Timer>();
        spawnTimer.Duration = Random.Range(MinSpawnDelay, MaxSpawnDelay);
        spawnTimer.Run();
    }
	
	// Update is called once per frame
	void Update () {
        if (spawnTimer.Finished)
        {
            SpawnBear();

            spawnTimer.Duration = Random.Range(MinSpawnDelay, MaxSpawnDelay);
            spawnTimer.Run();
        }
	}

    void SpawnBear()
    {
        Vector3 location = new Vector3(Random.Range(minSpawnX, maxSpawnX), Random.Range(minSpawnY, maxSpawnY), -Camera.main.transform.position.z);
        Vector3 worldLocation = Camera.main.ScreenToWorldPoint(location);

        GameObject teddyBear;
        int prefabNumber = Random.Range(0, 3);
        if(prefabNumber == 0)
        {
            teddyBear = Instantiate<GameObject>(pf_YellowBear, worldLocation, Quaternion.identity);
        }
        else if (prefabNumber == 1)
        {
            teddyBear = Instantiate<GameObject>(pf_GreenBear, worldLocation, Quaternion.identity);
        }
        else
        {
            teddyBear = Instantiate<GameObject>(pf_PurpleBear, worldLocation, Quaternion.identity);
        }
    }
}
