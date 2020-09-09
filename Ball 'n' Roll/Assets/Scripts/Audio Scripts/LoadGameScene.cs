using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using System;

public class LoadGameScene : MonoBehaviour
{
	public GameObject GameMusic;
	static public GameObject _GameMusic;
	public void ShowSkinScene()
	{
		PlayButtonScript.skinLoader.allowSceneActivation = true;	
	}
	private void Start()
	{
	    _GameMusic = Instantiate(GameMusic);
		DontDestroyOnLoad(GameMusic);
		ShowSkinScene();
	}

	public static void StopGameMusic()
	{
		Destroy(_GameMusic);
	}


}
