using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class ObstacleSpawnerScript : MonoBehaviour
{
    public GameObject Obstacle;
    public GameObject Checkpoint;
    public static bool timeController = true;
    // public static float spawnrate = 0.0001f;
    // public static float nextspawn = 0f;
    public static float randXcord;
    public static float zOperater = -98;
    public static int GreenPointSpawnerFactor = 0;
    public static int counter = 0;
    public Transform pos;
    public static Vector3 spawnVector = new Vector3(2f, -1.34f, -98f);
  //  public  GameObject[] obstaclesTodestroy = new GameObject[1000];
  //  public int secondcounter = 0;



    void Update()
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
            // if (zOperater % 70 == 0)
            // {
            if (GreenPointSpawnerFactor == 20)
            {
                spawnVector = new Vector3(randXcord, -1.34f, zOperater);
                pos.position = spawnVector;
                Instantiate(Checkpoint, pos.position, Quaternion.identity);
                zOperater = zOperater - 7;
                GreenPointSpawnerFactor = 0;
            }
            spawnVector = new Vector3(randXcord, -1.34f, zOperater);
            pos.position = spawnVector;
           // GameObject obstacle = Instantiate(Obstacle, pos.position, Quaternion.identity);
            Instantiate(Obstacle, pos.position, Quaternion.identity);
            zOperater = zOperater - 7;
         //   for (int i = 0; i < 1; i++)
         //   {
          //      obstaclesTodestroy[secondcounter] = obstacle;
          //  }
            GreenPointSpawnerFactor++;
          //  secondcounter++;
          //  for (int i = 0; i < 1; i++)
          //  {
          //      Destroy(this.obstaclesTodestroy[secondcounter]);

          //  }
        }
        // zOperater = zOperater - 7;
         counter++;

        

    }

}