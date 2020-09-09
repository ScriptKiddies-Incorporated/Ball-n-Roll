using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneCollisionScript : MonoBehaviour
{
    public Rigidbody Ball3;
    public static bool exCollCheck = true;

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.name == "BallPlayer")
        {
           if(exCollCheck == false)
           {
                Ball3.velocity = new Vector3(0, 0, -20);
                BehaviourMovement.forwardForce = 400;
                exCollCheck = true;
               RampCollisionCheckScript.collCheck = true;
                BoostScrpit.speedControl = 2f;
            }
        }

    }
}
