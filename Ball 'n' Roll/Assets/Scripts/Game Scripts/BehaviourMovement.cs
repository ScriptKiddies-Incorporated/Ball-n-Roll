using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using UnityEngine.SceneManagement;

public class BehaviourMovement : MonoBehaviour
{
    public GameObject ballPlayerNull;
    public Rigidbody Ball;
    public static bool pauseCondition = false;
    public int sidewaysForce;
    public static float forwardForce = 400f;
    public static bool planeCollisionChecker = true;

    void FixedUpdate()
    {
        if (ballPlayerNull != null)
        {
            Ball.AddForce(0, 0, -forwardForce * Time.deltaTime);
            if (Input.GetKey("a") || Input.GetKey("d") || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
            {
                if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
                {
                    Ball.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
                }
                if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
                {
                    Ball.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
                }
            }

            if (Ball.position.y < -50f)
            {
                print("GAME OVER!!!");
                ObstacleSpawnerScript.timeController = false;
                PlayerCollision.redSoundCondition = true;
                Destroy(gameObject);
                Thread.Sleep(500);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

            }


           // print(Ball.position.y);
            if (Ball.position.y <= 1.75f && Ball.position.y >= -1.43f)
            {
                planeCollisionChecker = true;
            }
            else
            {
                    planeCollisionChecker = false;
            }
           // print(planeCollisionChecker);
        }
    }
    

 }


