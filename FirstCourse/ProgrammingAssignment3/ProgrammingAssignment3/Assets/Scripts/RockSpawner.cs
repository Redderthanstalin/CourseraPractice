using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawner : MonoBehaviour
{

    [SerializeField]
    GameObject pf_whiteRock;
    [SerializeField]
    GameObject pf_greenRock;
    [SerializeField]
    GameObject pf_magentaRock;

    Timer spawnTimer;

    // Use this for initialization

    void Awake()
    {
        spawnTimer = gameObject.AddComponent<Timer>();
    }
    void Start()
    {
        // Instantiate a rock at the start
        InstantiateRandomRock();

        //Add the Spawn Timer, set it's duration and run it.
        
        spawnTimer.Duration = 3;
        spawnTimer.Run();
        Debug.Log(spawnTimer.Finished);
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] Rocks = GameObject.FindGameObjectsWithTag("Rock");
        //Check if the timer has finished
        if (spawnTimer.Finished)
        {
            //Build an array of Rocks and check to see if that array is under 3
            
            Debug.Log(Rocks.Length);
            if (Rocks.Length < 3)
            {
                //Call my method to instantiate a new random rock

                InstantiateRandomRock();
            }
        }

    }


    void InstantiateRandomRock()
    {
        int num = Random.Range(0, 3);

        if (num == 0)
        {
            Instantiate<GameObject>(pf_whiteRock, Vector3.zero, Quaternion.identity);
            spawnTimer.Duration = 3;
            spawnTimer.Run();
        }
        else if (num == 1)
        {
            Instantiate<GameObject>(pf_greenRock, Vector3.zero, Quaternion.identity);
            spawnTimer.Duration = 3;
            spawnTimer.Run();
        }
        else
        {
            Instantiate<GameObject>(pf_magentaRock, Vector3.zero, Quaternion.identity);
            spawnTimer.Duration = 3;
            spawnTimer.Run();
        }
    }
}
