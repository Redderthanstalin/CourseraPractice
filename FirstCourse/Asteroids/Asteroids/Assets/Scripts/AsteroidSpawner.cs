using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour {


    //Get a reference to the Prefab and the 3 sprites
    [SerializeField]
    GameObject AsteroidPrefab;

    [SerializeField]
    List<Sprite> Sprites = new List<Sprite>();

    //Vector 2 - Set the 4 spawn points Vectors
    Vector3 leftSpawn; 
    Vector3 topSpawn; 
    Vector3 rightSpawn; 
    Vector3 bottomSpawn; 


    // Use this for initialization
    void Start () {

        AsteroidPrefab.GetComponent<SpriteRenderer>().sprite = Sprites[Random.Range(0,Sprites.Count)];

        leftSpawn = new Vector3(ScreenUtils.ScreenLeft,  0, 0f);
        topSpawn = new Vector3(0, ScreenUtils.ScreenTop, 0f);
        rightSpawn = new Vector3(ScreenUtils.ScreenRight, 0, 0f);
        bottomSpawn = new Vector3(0, ScreenUtils.ScreenBottom, 0f);

        Debug.Log("Screen top is: " + ScreenUtils.ScreenTop + ". Screen bottom is: " + ScreenUtils.ScreenBottom);

        //spawn the prefab choosing one of the 3 sprites at random
        Instantiate(AsteroidPrefab, leftSpawn, Quaternion.identity);
        Instantiate(AsteroidPrefab, topSpawn, Quaternion.identity);
        Instantiate(AsteroidPrefab, rightSpawn, Quaternion.identity);
        Instantiate(AsteroidPrefab, bottomSpawn, Quaternion.identity);



    }
	
	// Update is called once per frame

}
