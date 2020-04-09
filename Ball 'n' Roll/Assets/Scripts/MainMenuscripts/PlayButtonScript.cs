using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayButtonScript : MonoBehaviour
{

	public static AsyncOperation audioLoader;
	public static AsyncOperation skinLoader;
	public static AsyncOperation gameLoader;
	private void Awake()
	{
		//audioLoader = SceneManager.LoadSceneAsync("AudioScene");
		//skinLoader = SceneManager.LoadSceneAsync("SkinSelector");
		//gameLoader = SceneManager.LoadSceneAsync("Game");
		//SceneManager.LoadSceneAsync("AudioScene");
		StartCoroutine(LoadScenesAsyncNow());
	}
	public void OnClickButton()
	{
		//   SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
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
