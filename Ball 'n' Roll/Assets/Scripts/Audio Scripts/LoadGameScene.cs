using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadGameScene : MonoBehaviour
{
	public void LoadPlayingScene()
	{			
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);		
	}
	private void Start()
	{
		LoadPlayingScene();
	}
}
