using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttons : MonoBehaviour {

    public Button StartButton, AgainButton, EndButton;

	// Use this for initialization
	void Start () {
        // Add listeners to buttons
        StartButton.onClick.AddListener(StartGame);
        AgainButton.onClick.AddListener(TryAgain);
        EndButton.onClick.AddListener(EndGame);
	}

    void StartGame ()
    {
        Debug.Log("'Start button' pressed, 'StartGame' triggered.");
    }

    void TryAgain()
    {
        Debug.Log("'Again button' pressed, TryAgain triggered.");
    }

    void EndGame()
    {
        Debug.Log("'End button' pressed, 'EndGame' triggered.");
        Debug.Log("Avengers assemble!");
    }

    // Update is called once per frame
    void Update () {
		
	}
}
