using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ChangeSettings : MonoBehaviour
{
	public AudioMixer mainAudioMixer;
	public TMPro.TMP_Dropdown quality;
	public int value;
	public static string key = "value";

	private void Start()
	{ 
		quality.value = PlayerPrefs.GetInt(key);
	}
	public void SetFullScreen(bool isFullScreen)
	{
		if (isFullScreen)
		{
			Screen.SetResolution(1920, 1080, true, 60);
			Screen.fullScreen = true;
		}
		else
		{
			Screen.fullScreen = false;
		}
	}

	public void SetVolume(float chosenVolume)
	{
		mainAudioMixer.SetFloat("masterVolume", chosenVolume);
	}

	public void SetQuality(int qualityIndex)
	{
		switch (qualityIndex)
		{
			case 0:
				QualitySettings.SetQualityLevel(2);
				break;

			case 1:
				QualitySettings.SetQualityLevel(1);
				break;

			case 2:
				QualitySettings.SetQualityLevel(0);
				break;
		}

	
		PlayerPrefs.SetInt(key, quality.value);
		
	}
}
