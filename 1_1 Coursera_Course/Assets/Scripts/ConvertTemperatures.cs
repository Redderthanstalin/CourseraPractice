using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConvertTemperatures : MonoBehaviour {

    public double originalFahrenheit = 0f;

    double Celsius;
    double Fahrenheit;

	// Use this for initialization
	void Start () {
        Celsius = ((originalFahrenheit - 32) / 9) * 5;
        Fahrenheit = ((Celsius * 9) / 5) + 32;


        print("The original value: " + originalFahrenheit);
        print(Celsius + " in celsius");
        print(Fahrenheit + " if you convert back to Fahrenheit");

    }

}
