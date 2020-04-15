using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class LoadSettings : MonoBehaviour
{

	public AudioMixer mainAudioMixer;
	private void Awake()
	{
		Screen.fullScreen = System.Convert.ToBoolean(PlayerPrefs.GetInt("fullscreen"));
		int qualityIndex = PlayerPrefs.GetInt("value");

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

		mainAudioMixer.SetFloat("masterVolume", PlayerPrefs.GetFloat("volume"));
	}
}
