using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;

public class Highscore : MonoBehaviour {

    private string path;
    private Text watch;

	// Use this for initialization
	void Start () {
        path = Path.Combine(Application.streamingAssetsPath, "TextFiles/highscore.txt");
        
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        watch = gameObject.GetComponent<Text>();

        if(sceneName == "EndScene")
        {
            if(GlobalVariables.newHighscore == true)
            {
                watch.text = " " + ReadHighscore() + "*"; // Mark new highscore
                GlobalVariables.newHighscore = false;

                return;
            }
            watch.text = ReadHighscore();
        }
    }

    public string ReadHighscore()
    {
        StreamReader reader = new StreamReader(path, true);
        string[] highscore = reader.ReadToEnd().Split("\n"[0]);
        string lastLine = highscore[highscore.Length - 2]; // Last line is empty, index starts at 0
        reader.Close();

        return lastLine;
    }

    public void WriteHighscore()
    {
        int lastLineInt = ConvertTimeToInt(ReadHighscore());
        int watchInt = ConvertTimeToInt(watch.text);

        if(watchInt > lastLineInt)
        {
            Debug.Log("New highscore");
            GlobalVariables.newHighscore = true;

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
