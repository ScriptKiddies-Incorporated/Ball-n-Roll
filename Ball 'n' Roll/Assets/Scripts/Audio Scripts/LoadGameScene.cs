using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadGameScene : MonoBehaviour
{
	public void ShowSkinScene()
	{
		PlayButtonScript.skinLoader.allowSceneActivation = true;	
	}
	private void Start()
	{
		ShowSkinScene();
	}
}
