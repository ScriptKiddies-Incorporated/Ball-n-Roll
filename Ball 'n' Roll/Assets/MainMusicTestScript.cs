using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMusicTestScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

	public void Awake()
	{
		DontDestroyOnLoad(transform.gameObject);
		if (MusicScript.isStartMusicFirstTime)
		{
			this.GetComponent<AudioSource>().Play();
		}
	}

	// Update is called once per frame
	void Update()
    {
		if (MusicScript.shouldMainMusicBeStopped)
		{
			Destroy(transform.gameObject);
		}
		
	}
}
