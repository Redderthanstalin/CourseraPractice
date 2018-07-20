using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script used for week 1_1
public class PrintPercent : MonoBehaviour {

    const int MaxScore = 100;

     

	// Update is called once per frame
	void Start () {
        int Score = 60;

        float percent = (float)Score / MaxScore;

        print(percent * 100 + "%");
	}
}
