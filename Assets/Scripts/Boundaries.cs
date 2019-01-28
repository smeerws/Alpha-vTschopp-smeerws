using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundaries : MonoBehaviour {

    public GameObject parent;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        float copyAxis = parent.transform.position.x;
        Vector2 position = new Vector2(copyAxis, transform.position.y);

        transform.position = position;
	}
}
