using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
public class ChangeSettings : MonoBehaviour
{
	public AudioMixer mainAudioMixer;
	public Dropdown quality;
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

		//quality.
		
	}
}
