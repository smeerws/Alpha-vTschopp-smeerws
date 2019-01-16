using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour {

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
    {
        transform.Translate(Vector2.right * Time.deltaTime * GlobalVariables.speed);

        if (Input.GetKey("w") || Input.GetKey("up"))
        {
            if (GlobalVariables.collision == false)
            {
                transform.Translate(Vector2.up * Time.deltaTime * GlobalVariables.speed * 2);
            }
        }
        if (Input.GetKey("s") || Input.GetKey("down"))
        {
            if (GlobalVariables.collision == false)
            {
                transform.Translate(Vector2.down * Time.deltaTime * GlobalVariables.speed * 2);
            }
        }
    }
}
