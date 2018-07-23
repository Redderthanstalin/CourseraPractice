using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamerTag : MonoBehaviour {

    [SerializeField]
    Text gamertagText;

    InputField gamertag;

    float secondsSinceLastOutput = 0;

	// Use this for initialization
	void Start () {
        gamertag = gamertagText.GetComponent<InputField>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
