using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleDestroyScript : MonoBehaviour
{
    public Transform ObstacleObj;
    

    void FixedUpdate()
    {
        if(ObstacleObj.position.z > ObstacleSpawnerScript.zCoordinates + 5)
        {
            Destroy(gameObject);
        }
    }

}
