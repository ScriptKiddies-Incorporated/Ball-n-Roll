using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepMainMusicAlive : MonoBehaviour
{
    void Awake()
	{
		DontDestroyOnLoad(transform.gameObject);
	}
}
