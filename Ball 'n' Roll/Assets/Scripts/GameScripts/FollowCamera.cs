using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class FollowCamera : MonoBehaviour
{
    public  Transform BallPlayerCam;
    public  Vector3 offset;
    public bool camfactor1 = true;
    public GameObject ballPlayerNull1;

    void Update()
    {

        if (ballPlayerNull1 != null)
        {
            transform.position = BallPlayerCam.position + offset;
        }      

    }

}

