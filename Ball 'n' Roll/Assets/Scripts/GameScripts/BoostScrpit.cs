using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostScrpit : MonoBehaviour
{

    public Transform ballObject;

    void Update()
    {
        if(RampCollisionCheckScript.collCheck == false &&  BehaviourMovement.planeCollisionChecker == false)
        {
            BehaviourMovement.forwardForce = 1750;
            PlaneCollisionScript.exCollCheck = false;
        }

    }
}
