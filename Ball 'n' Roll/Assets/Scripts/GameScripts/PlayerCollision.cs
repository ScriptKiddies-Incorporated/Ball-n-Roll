using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    public static bool cameraPos = true;
	public GameObject greenSound;
    public static bool redSoundCondition = true;

    private void OnCollisionEnter(Collision collisionInfo)
    {
        
        if (collisionInfo.collider.name == "Obstacle" || collisionInfo.collider.name == "Obstacle(Clone)")
        {
            ObstacleSpawnerScript.timeController = false;
            redSoundCondition = true;
			Destroy(gameObject);
            Thread.Sleep(200);
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		}

		if (collisionInfo.collider.name == "GreenCheckpoint(Clone)")
		{
			Instantiate(greenSound);
		}
    }

}
