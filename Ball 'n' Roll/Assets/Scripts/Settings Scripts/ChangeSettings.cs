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
	public Slider volumeSlider;
	public Toggle fullscreen;
	public int value;
	public string qualityKey = "value";

	private void Start()
	{ 
		quality.value = PlayerPrefs.GetInt(qualityKey);
		volumeSlider.value = PlayerPrefs.GetFloat("volume");
		fullscreen.GetComponent<Toggle>().isOn = System.Convert.ToBoolean(PlayerPrefs.GetInt("fullscreen"));
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

		PlayerPrefs.SetInt("fullscreen", System.Convert.ToInt32(fullscreen.GetComponent<Toggle>().isOn));
	}

	public void SetVolume(float chosenVolume)
	{
		mainAudioMixer.SetFloat("masterVolume", chosenVolume);
		PlayerPrefs.SetFloat("volume", chosenVolume);
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

	
		PlayerPrefs.SetInt(qualityKey, quality.value);
		
	}
}
