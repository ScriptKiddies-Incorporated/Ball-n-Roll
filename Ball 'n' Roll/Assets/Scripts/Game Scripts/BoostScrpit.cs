using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostScrpit : MonoBehaviour
{

    public Transform ballObject;
    public static float speedControl = 1.5f;

    void Update()
    {
        if(RampCollisionCheckScript.collCheck == false &&  BehaviourMovement.planeCollisionChecker == false)
        {
            // BehaviourMovement.forwardForce = 1750;
            if (BehaviourMovement.forwardForce <= 1000f)
            {
                BehaviourMovement.forwardForce = BehaviourMovement.forwardForce + speedControl;
            }
                PlaneCollisionScript.exCollCheck = false;
            if (speedControl > 0.5f)
            {
                speedControl = speedControl - 0.0005f;
            }
        }
        else
        {
            speedControl = 1.5f;
        }

    }
}
