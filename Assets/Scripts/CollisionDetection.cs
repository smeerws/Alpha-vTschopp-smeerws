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
        if (collision.gameObject.tag == "BoundaryTop")
        {
            GlobalVariables.collisionTop = true;
            return;
        }
        if (collision.gameObject.tag == "BoundaryBottom")
        {
            GlobalVariables.collisionBottom = true;
        }

        SceneManager.LoadScene("EndScene", LoadSceneMode.Single);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        GlobalVariables.collisionTop = false;
        GlobalVariables.collisionBottom = false;
    }

    // Update is called once per frame
    void Update () {

	}
}
