using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour {


    //Get a reference to the Prefab and the 3 sprites
    [SerializeField]
    GameObject AsteroidPrefab;

    [SerializeField]
    List<Sprite> Sprites = new List<Sprite>();

    List<Vector3> SpawnPoints = new List<Vector3>();

    //Vector 2 - Set the 4 spawn points Vectors
    Vector3 leftSpawn; 
    Vector3 topSpawn; 
    Vector3 rightSpawn; 
    Vector3 bottomSpawn;

    int numOfAsteroids = 4;


    // Use this for initialization
    void Start () {

        //Initialize the spawn Points
        leftSpawn = new Vector3(ScreenUtils.ScreenLeft, 0, 0f);
        topSpawn = new Vector3(0, ScreenUtils.ScreenTop, 0f);
        rightSpawn = new Vector3(ScreenUtils.ScreenRight, 0, 0f);
        bottomSpawn = new Vector3(0, ScreenUtils.ScreenBottom, 0f);
        
        //Add the spawn points into a list so I can use a for loop
        SpawnPoints.Add(leftSpawn);
        SpawnPoints.Add(topSpawn);
        SpawnPoints.Add(rightSpawn);
        SpawnPoints.Add(bottomSpawn);

        //Using a for loop, Instantiate each of the 4 Asteroids with a different renderer. I did it this way because when I first initized the random sprite and then instantiated all Asteroids were the same sprite.
        for (int i = 0; i < numOfAsteroids; i++)
        {
            AsteroidPrefab.GetComponent<SpriteRenderer>().sprite = Sprites[Random.Range(0, Sprites.Count)];
            Instantiate(AsteroidPrefab, SpawnPoints[i], Quaternion.identity);

        }

    }


}
