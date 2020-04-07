using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepSoundAlive : MonoBehaviour
{
    void Awake()
	{
		DontDestroyOnLoad(transform.gameObject);
	}
}
