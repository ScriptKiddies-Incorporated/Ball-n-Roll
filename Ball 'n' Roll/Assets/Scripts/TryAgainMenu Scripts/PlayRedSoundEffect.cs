using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayRedSoundEffect : MonoBehaviour
{
	public GameObject redSound;
    void Start()
    {
        if (PlayerCollision.redSoundCondition == true)
        {
            Instantiate(redSound);
        }
      }
}
