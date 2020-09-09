using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{

    public GameObject greenParticleSystem;
    public Transform greenParticleSystemPos;
    public Vector3 greenParticleSystemVec = new Vector3(0, 0, 0);

    public static bool exBool = true;
	public GameObject particleSystem;
	public Transform particleSystemPos;
    public Transform ballPlayer;
    public Vector3 particleSystemVec = new Vector3(0, 0, 0);

    public Rigidbody ridBallPlayer;

    public static bool cameraPos = true;
	public GameObject greenSound;
	public static bool redSoundCondition = true;

    public static bool collisionBool = false;

	public static AsyncOperation tryAgainLoader;


	private void Awake()
	{
		StartCoroutine(LoadTryAgainAsyncNow());
		//StartCoroutine(UnloadMainMenu());
	}

	public void OnCollisionEnter(Collision collisionInfo)
	{

		particleSystemPos.position = ballPlayer.position + particleSystemVec;

		if (collisionInfo.collider.name == "Obstacle" || collisionInfo.collider.name == "Obstacle(Clone)" || collisionInfo.collider.name == "PrimaryObstacle")
		{
			ObstacleSpawnerScript.timeController = false;
			redSoundCondition = true;
            exBool = false;
            collisionBool = true;
            BehaviourMovement.forwardForce = 400;
            PlaneCollisionScript.exCollCheck = true;
            RampCollisionCheckScript.collCheck = true;
            Destroy(gameObject);
			Instantiate(particleSystem, particleSystemPos.position, Quaternion.identity);

		}

		if (collisionInfo.collider.name == "GreenCheckpoint(Clone)")
		{
            ridBallPlayer.velocity = Vector3.zero;
            BehaviourMovement.forwardForce = 400;
            PlaneCollisionScript.exCollCheck = true;
            RampCollisionCheckScript.collCheck = true;
            Instantiate(greenSound);
            greenParticleSystemPos.position = ballPlayer.position + greenParticleSystemVec;
            Instantiate(greenParticleSystem, greenParticleSystemPos.position, Quaternion.identity);
        }
	}

	IEnumerator LoadTryAgainAsyncNow()
	{
		yield return null;
		tryAgainLoader = SceneManager.LoadSceneAsync("TryAgainMenu");
		tryAgainLoader.allowSceneActivation = false;
		yield return null;
	}

	/*IEnumerator UnloadMainMenu()
	{
		SceneManager.UnloadSceneAsync("MainMenu");
		return null;
	}*/

}
