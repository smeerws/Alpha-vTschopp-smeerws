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

        if(watchInt > lastLineInt)
        {
            Debug.Log("New highscore");

            StreamWriter writer = new StreamWriter(path, true);
            writer.WriteLine(watch.text);
            writer.Close();
        }
    }

    public int ConvertTimeToInt(string time)
    {
        string[] splittedString = time.Split(":"[0]);

        int m = int.Parse(splittedString[0]);
        int s = int.Parse(splittedString[1]);
        int ms = int.Parse(splittedString[2]);

        int result = m * 600 + s * 100 + ms;

        Debug.Log("Result of " + time + ": " + result + "ms");
        return result;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
