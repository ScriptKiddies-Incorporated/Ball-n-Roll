using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
	public static int exCounter = 0;
	public static bool exBool = true;
	public GameObject particleSystem;
	public Transform particleSystemPos;
	public Transform ballPlayer;
	public Vector3 particleSystemVec = new Vector3(0, 0, 0);

	public static bool cameraPos = true;
	public GameObject greenSound;
	public static bool redSoundCondition = true;

	public static AsyncOperation tryAgainLoader;


	private void Awake()
	{
		StartCoroutine(LoadTryAgainAsyncNow());
		StartCoroutine(UnloadMainMenu());
	}

	public void OnCollisionEnter(Collision collisionInfo)
	{
		particleSystemPos.position = ballPlayer.position + particleSystemVec;

		if (collisionInfo.collider.name == "Obstacle" || collisionInfo.collider.name == "Obstacle(Clone)")
		{
			ObstacleSpawnerScript.timeController = false;
			redSoundCondition = true;
			Destroy(gameObject);
			Instantiate(particleSystem, particleSystemPos.position, Quaternion.identity);
			Thread.Sleep(2000);
			//  exBool = false;
			// if (exCounter == 100)
			// {
			//  exBool = false;

			// SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
			tryAgainLoader.allowSceneActivation = true;
			// }
		}

		if (collisionInfo.collider.name == "GreenCheckpoint(Clone)")
		{
			Instantiate(greenSound);
		}
	}

	IEnumerator LoadTryAgainAsyncNow()
	{
		yield return null;
		tryAgainLoader = SceneManager.LoadSceneAsync("TryAgainMenu");
		tryAgainLoader.allowSceneActivation = false;
		yield return null;
	}

	IEnumerator UnloadMainMenu()
	{
		SceneManager.UnloadSceneAsync("MainMenu");
		return null;
	}
}
