using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPlayerCollision : MonoBehaviour
{
    public void OnCollisionEnter(Collision collisionInfo)
    {
      
        if(collisionInfo.collider.name == "BallPlayer")
        {
            Destroy(gameObject);
        }
    }
}