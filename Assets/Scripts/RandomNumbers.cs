using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class RandomNumbers : MonoBehaviour {

    public Text randomResult;

	// Use this for initialization
	void Start () {
        // RandomNumberGenerator1();
        // Debug.Log(RandomNumberGenerator2());

        // RandomNumberGenerator3(123, 1, 5);
        // Debug.Log(RandomNumberGenerator4(123, 1, 5));

        randomResult.text = RandomNumberGenerator4(123, 1, 5).ToString();
    }

    public void RandomNumberGenerator1()
    {
        System.Random randomNumber = new System.Random(123);
        Debug.Log(randomNumber.Next(1, 5));
    }

    public int RandomNumberGenerator2()
    {
        System.Random randomNumber = new System.Random(123);
        return randomNumber.Next(1, 5);
    }

    public void RandomNumberGenerator3(int seed, int min, int max)
    {
        System.Random randomNumber = new System.Random(seed);
        Debug.Log(randomNumber.Next(min, max));
    }

    public int RandomNumberGenerator4(int seed, int min, int max)
    {
        System.Random randomNumber = new System.Random(seed);
        return randomNumber.Next(min, max);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
