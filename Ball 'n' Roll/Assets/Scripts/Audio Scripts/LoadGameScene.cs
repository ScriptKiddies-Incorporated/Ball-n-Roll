using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;



public class LoadGameScene : MonoBehaviour
{
	public GameObject GameMusic;
	public void ShowSkinScene()
	{
		PlayButtonScript.skinLoader.allowSceneActivation = true;	
	}
	private void Start()
	{
		Instantiate(GameMusic);
		DontDestroyOnLoad(GameMusic);
		ShowSkinScene();
	}
}
