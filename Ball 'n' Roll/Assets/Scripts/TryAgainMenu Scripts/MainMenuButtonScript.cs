using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtonScript : MonoBehaviour
{
    public void MainMenu()
    {
        ScoreText.objCount = 0;
        ScoreText.cordChecker = 0;
		ScoreText.timeController2 = false;

		VelocityCheckerScript.timeCounter = 0;
        VelocityCheckerScript.secTimeCounter = 0;

        PlayerCollision.exBool = true;
        PlayerCollision.collisionBool = false;

        MovingObstacleScript.moveForce = 0;
        PlaneCollisionScript.exCollCheck = true;
        BehaviourMovement.forwardForce = 400;
        BoostScrpit.speedControl = 1.5f;

		LoadGameScene.StopGameMusic();
		MusicScript.isStartMusicFirstTime = true;
		MusicScript.shouldMainMenuMusicBeStopped = false; // exp


		SceneManager.LoadScene("MainMenu");
    }
}
