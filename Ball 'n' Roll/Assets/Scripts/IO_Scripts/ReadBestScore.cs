using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ReadBestScore : MonoBehaviour
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
	void Start()
	{
		SetupDataDir();
		  
	}
	
}


