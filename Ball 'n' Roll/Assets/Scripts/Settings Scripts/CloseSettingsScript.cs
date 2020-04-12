using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CloseSettingsScript : MonoBehaviour
{
	public void OnButtonClick()
	{
		SceneManager.LoadScene("MainMenu");
	}
}
