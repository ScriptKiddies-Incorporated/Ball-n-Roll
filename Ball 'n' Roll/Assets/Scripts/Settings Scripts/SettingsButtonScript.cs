using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsButtonScript : MonoBehaviour
{
	// Start is called before the first frame update
	public GameObject gameMusic;
	public GameObject mainMenuMusic;
	

	private void Awake()
	{
		DontDestroyOnLoad(mainMenuMusic);
		DontDestroyOnLoad(transform.gameObject);
	}
	public void OnButtonClick()
    {
		DontDestroyOnLoad(transform.gameObject);
		PlayButtonScript.audioLoader.allowSceneActivation = false;
		/*if (MusicScript.isSettingsFirstTime)
		{
			MusicScript.isSettingsFirstTime = false;
			SceneManager.LoadScene("Settings Menu");
		}
		else
		{
			SceneManager.SetActiveScene(SceneManager.GetSceneByName("Settings Menu"));
			Debug.Log("scene loading");
			print("load scene");
		}*/
		SceneManager.LoadScene("Settings Menu");
		//Destroy();
	}

}
