using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RampCollisionCheckScript : MonoBehaviour
{
    public static bool collCheck = true;
    public void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.name == "BallPlayer")
        {
            collCheck = false;
        }

    }
}
