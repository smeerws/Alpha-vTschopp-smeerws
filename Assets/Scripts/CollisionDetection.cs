using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDetection : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Boundary top")
        {
            GlobalVariables.collisionTop = true;
            return;
        }
        if (collision.gameObject.name == "Boundary bottom")
        {
            GlobalVariables.collisionBottom = true;
            return;
        }

        SceneManager.LoadScene("EndScene", LoadSceneMode.Single);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Boundary top")
        {
            GlobalVariables.collisionTop = false;
        }
        if (collision.gameObject.name == "Boundary bottom")
        {
            GlobalVariables.collisionBottom = false;
        }
    }

    // Update is called once per frame
    void Update () {

	}
}
