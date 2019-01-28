using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour {

    // Use this for initialization
    void Start ()
    {
        GlobalVariables.speed = 2f;
	}
	
	// Update is called once per frame
	void Update () 
    {
        transform.Translate(Vector2.right * Time.deltaTime * GlobalVariables.speed); // Side movement

        if (Input.GetKey("w") || Input.GetKey("up"))
        {
            if (GlobalVariables.collisionTop == false)
            {
                transform.Translate(Vector2.up * Time.deltaTime * GlobalVariables.speed * 2);
            }
        }
        if (Input.GetKey("s") || Input.GetKey("down"))
        {
            if (GlobalVariables.collisionBottom == false)
            {
                transform.Translate(Vector2.down * Time.deltaTime * GlobalVariables.speed * 2);
            }
        }
    }
}
