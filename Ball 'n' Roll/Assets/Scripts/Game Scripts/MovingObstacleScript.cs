using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObstacleScript : MonoBehaviour
{

    public Rigidbody Obstacle;
    public static float moveForce = 0;
    public bool moveBool = true;
    public Texture test;
    public Renderer renderer;


    void FixedUpdate()
    {
        if (PlayerCollision.collisionBool == true)
        {
            Obstacle.constraints = RigidbodyConstraints.FreezePositionX;
            Obstacle.constraints = RigidbodyConstraints.FreezeRotationX;
        }

        if (gameObject.transform.position.z % 70 == 0)
        {
            if (ScoreText.score > 49)
            {
                moveForce = 100;
            }
            if (ScoreText.score > 99)
            {
                moveForce = 200;
            }

            if (moveBool == true)
            {
                Obstacle.AddForce(moveForce * Time.deltaTime, 0, 0);
            }
            else
            {
                Obstacle.AddForce(-moveForce * Time.deltaTime, 0, 0);
            }
            if (gameObject.transform.position.x <= -5.5 && ScoreText.score > 49)
            {

                Obstacle.velocity = new Vector3(1, 0, 0);
                moveBool = true;
            }
            if (gameObject.transform.position.x >= 3.3 && ScoreText.score > 49)
            {

                Obstacle.velocity = new Vector3(-1, 0, 0);
                moveBool = false;
            }
        }

    }
}
