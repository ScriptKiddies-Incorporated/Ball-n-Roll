using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostScrpit : MonoBehaviour
{

    public Transform ballObject;
    public static float speedControll = 1.5f;

    void Update()
    {
        if(RampCollisionCheckScript.collCheck == false &&  BehaviourMovement.planeCollisionChecker == false)
        {
            // BehaviourMovement.forwardForce = 1750;
            if (BehaviourMovement.forwardForce <= 1000f)
            {
                BehaviourMovement.forwardForce = BehaviourMovement.forwardForce + speedControll;
            }
                PlaneCollisionScript.exCollCheck = false;
            if (speedControll > 0.5f)
            {
                speedControll = speedControll - 0.0005f;
            }
        }
        else
        {
            speedControll = 1.5f;
        }

    }
}
