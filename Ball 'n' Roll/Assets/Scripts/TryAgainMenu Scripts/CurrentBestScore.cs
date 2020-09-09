using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class CurrentBestScore : MonoBehaviour
{
    public Text CurrentBestScore1;
    public static int bestScore = 0;
	static string userName = System.Environment.UserName;
	public static string dirPath = "C:/Users/" + userName + "/AppData/Local/BallnRoll/";
	public static string filePath = "C:/Users/" + userName + "/AppData/Local/BallnRoll/BestScore.bnr";

	public static void WriteScoreToDisk(int score)
	{

		StreamWriter writer = new StreamWriter(filePath);
		if (writer != null)
		{
			writer.BaseStream.Seek(0, 0);
			writer.WriteLine(score);
			writer.Flush();
			writer.Close();
		}
	}

	void Update()
    {
        if (ScoreText.score > bestScore)
        {
			
			bestScore = ScoreText.score;
			CurrentBestScore1.text = "High Score: " + bestScore.ToString("0");
			WriteScoreToDisk(bestScore);
        }
        else
        {
            CurrentBestScore1.text = "High Score: " + bestScore.ToString("0");
        }
    }
}
