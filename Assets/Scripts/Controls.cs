using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour {

    private float cameraLimit = 10; // Set limits for camera movement along y

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
    {
        transform.Translate(Vector2.right * Time.deltaTime * GlobalVariables.speed);

        if (Input.GetKey("w") || Input.GetKey("up"))
        {
            if (transform.position.y <= cameraLimit)
            {
                transform.Translate(Vector2.up * Time.deltaTime * GlobalVariables.speed * 2);
            }
        }
        if (Input.GetKey("s") || Input.GetKey("down"))
        {
            if (transform.position.y >= cameraLimit * (-1))
            {
                transform.Translate(Vector2.down * Time.deltaTime * GlobalVariables.speed * 2);
            }
        }
    }
}
