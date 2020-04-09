using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class ObstacleSpawnerScript : MonoBehaviour
{
    public int greenInterval;
    public GameObject Obstacle;
    public GameObject Checkpoint;
    public static bool timeController = true;

    public static float randXcord;
    public static float zOperater = -98;
    public static int GreenPointSpawnerFactor = 0;
    public static int counter = 0;
    public Transform pos; 
    public static Vector3 spawnVector = new Vector3(2f, -1.34f, -98f);


    void Update()
    {
        if (PlayerCollision.exBool != false)
        {
            if (counter % 10 == 0)
            {

                if (timeController == false)
                {
                    zOperater = -98;
                    timeController = true;
                    counter = 0;
                }
                randXcord = Random.Range(-5.52f, 3.36f);
                if (GreenPointSpawnerFactor == greenInterval)
                {
                    spawnVector = new Vector3(randXcord, -1.34f, zOperater);
                    pos.position = spawnVector;
                    Instantiate(Checkpoint, pos.position, Quaternion.identity);
                    zOperater = zOperater - 7;
                    GreenPointSpawnerFactor = 0;
                }
                spawnVector = new Vector3(randXcord, -1.34f, zOperater);
                pos.position = spawnVector;
                Instantiate(Obstacle, pos.position, Quaternion.identity);
                zOperater = zOperater - 7;

                GreenPointSpawnerFactor++;

            }
            counter++;

        }
        if (PlayerCollision.exBool == false)
        {
              Invoke("Waiter", 2);     
        }

    }

    public void Waiter()
    {
        PlayerCollision.tryAgainLoader.allowSceneActivation = true;
    }

}