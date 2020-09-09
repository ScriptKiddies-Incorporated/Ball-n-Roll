using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class LoadBestScore : MonoBehaviour
{
	static string userName = System.Environment.UserName;
    public static string dirPath = "C:/Users/" + userName + "/AppData/Local/BallnRoll/";
    public static string filePath = "C:/Users/" + userName + "/AppData/Local/BallnRoll/BestScore.bnr";

	public static void SetupDataDir()
	{
		if (!Directory.Exists(dirPath))
		{
			Directory.CreateDirectory(dirPath);
		}
	}

	public static int LoadBestScoreFromDisk()
	{
		if (File.Exists(filePath) == false) return 0;
		StreamReader reader = new StreamReader(filePath);
		int score = 0;

		if (reader != null)
		{
			score = int.Parse(reader.ReadLine());
			reader.Close();
		}

		return score;
	}
	void Start()
	{
		SetupDataDir();

		if (File.Exists(filePath) == false)
		{
			CurrentBestScore.WriteScoreToDisk(0);
		}
			CurrentBestScore.bestScore = LoadBestScoreFromDisk();
		  
	}
	
}


