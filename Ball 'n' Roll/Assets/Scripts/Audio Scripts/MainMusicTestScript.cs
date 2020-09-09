using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMusicTestScript : MonoBehaviour
{

	//GameObject StartMusic;
    // Start is called before the first frame update
    void Start()
    {
        
    }

	public void Awake()
	{
	//	DontDestroyOnLoad(transform.gameObject);
		//DontDestroyOnLoad(StartMusic);
		DontDestroyOnLoad(this);
		if (MusicScript.isStartMusicFirstTime)
		{
			this.GetComponent<AudioSource>().Play();
		}
	}

	// Update is called once per frame
	void Update()
    {
		if (MusicScript.shouldMainMenuMusicBeStopped)
		{
			Destroy(transform.gameObject);
			this.GetComponent<AudioSource>().Stop();
		}
		
	}
}
