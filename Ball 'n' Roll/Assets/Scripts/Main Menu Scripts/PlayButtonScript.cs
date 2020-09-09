using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayButtonScript : MonoBehaviour
{

	public static AsyncOperation audioLoader;
	public static AsyncOperation skinLoader;
	public static AsyncOperation gameLoader;
	public GameObject StartMusic;
	
	private void Awake()
	{
		DontDestroyOnLoad(StartMusic);
		StartCoroutine(LoadScenesAsyncNow());
	}

	void Start()
	{
		if (MusicScript.isStartMusicFirstTime)
		{
			Instantiate(StartMusic);		
			StartMusic.SetActive(true);
			MusicScript.isStartMusicFirstTime = false;
		}
	}
	public void OnClickButton()
	{
		MusicScript.shouldMainMenuMusicBeStopped = true;
		audioLoader.allowSceneActivation = true;
    }

	IEnumerator LoadScenesAsyncNow()
	{
		yield return null;
	    audioLoader = SceneManager.LoadSceneAsync("AudioScene");
		audioLoader.allowSceneActivation = false;

	    skinLoader = SceneManager.LoadSceneAsync("SkinSelecter");
		skinLoader.allowSceneActivation = false;

	    gameLoader = SceneManager.LoadSceneAsync("Game");
		gameLoader.allowSceneActivation = false;

		yield return null;
	}
}
