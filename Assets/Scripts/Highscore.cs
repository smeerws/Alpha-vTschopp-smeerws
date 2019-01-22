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

        StreamReader reader = new StreamReader(path, true);
        string[] highscore = reader.ReadToEnd().Split("\n"[0]);
        string lastLine = highscore[highscore.Length - 2]; // Last line is empty, index starts at 0
        reader.Close();

        int lastLineInt = ConvertTimeToInt(lastLine);
        int watchInt = ConvertTimeToInt(watch.text);

        if(lastLineInt != watchInt)
        {
            StreamWriter writer = new StreamWriter(path, true);
            writer.WriteLine(watch.text);
            writer.Close();
        }
    }

    public int ConvertTimeToInt(string time)
    {
        string[] splittedString = time.Split("\n"[0]);
        return result;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
