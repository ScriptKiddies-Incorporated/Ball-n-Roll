using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    public static bool cameraPos = true;

    private void OnCollisionEnter(Collision collisionInfo)
    {
        
        if (collisionInfo.collider.name == "Obstacle" || collisionInfo.collider.name == "Obstacle(Clone)")
        {
            print("Obstacle ahead!!!");
            ObstacleSpawnerScript.timeController = false;
            Destroy(gameObject);
             Thread.Sleep(500);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

}
