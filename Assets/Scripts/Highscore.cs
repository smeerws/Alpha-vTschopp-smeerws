using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class Highscore : MonoBehaviour {

    private Text watch;

	// Use this for initialization
	void Start () {
        watch = gameObject.GetComponent<Text>();
	}

    public void WriteHighscore()
    {
        string path = "Assets/TextFiles/highscore.txt";

        StreamWriter writer = new StreamWriter(path, true);
        writer.WriteLine(watch.text);
        writer.Close();
    }

    // Update is called once per frame
    void Update () {
		
	}
}
