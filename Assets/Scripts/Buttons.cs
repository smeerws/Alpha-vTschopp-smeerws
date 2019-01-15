using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

    // Button functionality
    public void StartGame ()
    {
        Debug.Log("'Start button' pressed, 'StartGame' triggered.");
        SceneManager.LoadScene("MainScene", LoadSceneMode.Single);
    }

    public void TryAgain()
    {
        Debug.Log("'Again button' pressed, 'TryAgain' triggered.");
        SceneManager.LoadScene("MainScene", LoadSceneMode.Single);
    }

    public void EndGame()
    {
        Debug.Log("'End button' pressed, 'EndGame' triggered.");
        Debug.Log("Avengers assemble!");
        Application.Quit();
    }

    // Update is called once per frame
    void Update () {
		
	}
}