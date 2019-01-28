using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildWorld : MonoBehaviour {

    public GameObject obstacle;

    private float timer;
    private int offsetCounter = 12;
    private int offsetDistance = 4; // Place obstacles in x units

	// Use this for initialization
	void Start ()
    {
        Debug.Log("'BuildWorld.cs' initialized.");
        CreateWorld(offsetCounter);
	}

    // Create world - performance issues!
    void CreateWorld(int offset)
    {
        for (int i = 0; i < 20; i++)
        {
            Instantiate(obstacle, new Vector2(offset, (i * 2) + Random.Range(0, 4) - 20), Quaternion.identity, transform);
        }
    }

    // Update is called once per frame
    void Update ()
    {
        timer += Time.deltaTime;

        if (timer > Time.deltaTime * GlobalVariables.speed)
        {
            offsetCounter = offsetCounter + offsetDistance;
            CreateWorld(offsetCounter);

            timer = 0;
        }
    }
}
