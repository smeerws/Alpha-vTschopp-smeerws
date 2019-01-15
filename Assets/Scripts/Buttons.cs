using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttons : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

    // Button functionality
    public void StartGame ()
    {
        Debug.Log("'Start button' pressed, 'StartGame' triggered.");
    }

    public void TryAgain()
    {
        Debug.Log("'Again button' pressed, 'TryAgain' triggered.");
    }

    public void EndGame()
    {
        Debug.Log("'End button' pressed, 'EndGame' triggered.");
        Debug.Log("Avengers assemble!");
    }

    // Update is called once per frame
    void Update () {
		
	}
}