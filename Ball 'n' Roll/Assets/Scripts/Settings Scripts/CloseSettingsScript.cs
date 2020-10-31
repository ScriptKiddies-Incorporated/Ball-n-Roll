using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CloseSettingsScript : MonoBehaviour
{
	public void OnButtonClick()
	{
		PlayerPrefs.Save();
	    SceneManager.LoadScene("MainMenu"); //.Additive
 		//SceneManager.SetActiveScene(SceneManager.GetSceneByBuildIndex(5));
	}
}
