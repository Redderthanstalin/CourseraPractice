using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Changes character on left mouse button
/// </summary>
public class CharacterChanger : MonoBehaviour
{
    //Used for the Array Syntax
    //    GameObject[] prefabCharacters = new GameObject[4];
    List<GameObject> prefabCharacters = new List<GameObject>();


    // need for location of new character
    GameObject currentCharacter;

    // first frame input support
    bool previousFrameChangeCharacterInput = false;

    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start()
    {
        //populate array with characters
        //for(int i = 0; i < prefabCharacters.Length; i++)
        //{
            
        //    prefabCharacters[i] = (GameObject)Resources.Load(@"prefabs\Character" + i.ToString());
        //}
        
        //used to populate list with Characters
        for(int i = 0; i <= 4; i++)
        {
            prefabCharacters.Add((GameObject)Resources.Load(@"prefabs\Character" + i.ToString()));
        }


        currentCharacter = Instantiate<GameObject>(
            prefabCharacters[0], Vector3.zero,
            Quaternion.identity);
    }

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update()
    {
        // change character on left mouse button
        if (Input.GetAxis("ChangeCharacter") > 0)
        {
            // only change character on first input frame
            if (!previousFrameChangeCharacterInput)
            {
                previousFrameChangeCharacterInput = true;

                // save current position and destroy current character
                Vector3 position = currentCharacter.transform.position;
                Destroy(currentCharacter);

                // instantiate a new random character
                int prefabNumber = Random.Range(0, 4);

                currentCharacter = Instantiate(prefabCharacters[prefabNumber], position, Quaternion.identity);


            }
        }
        else
        {
            // no change character input
            previousFrameChangeCharacterInput = false;
        }
    }
}
