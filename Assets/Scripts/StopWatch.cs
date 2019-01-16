using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StopWatch : MonoBehaviour {

    private Text watch;
    private float timer;

	// Use this for initialization
	void Start () {
        watch = gameObject.GetComponent<Text>();
        watch.text = "00:00:00";
	}
	
	// Update is called once per frame
	void Update () {
        timer = Time.deltaTime;
	}
}
