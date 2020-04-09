using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScriptPhoenixNebula : MonoBehaviour
{
    public void ButtonscriptPhoenixNebula()
    {
        ScoreText.objCount = 0;
        ScoreText.cordChecker = 0;
        ScoreText.timeController2 = false;
        ButtonScriptHexagonCarbon.skinChoice = "PhoenixNebula";
		// SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		PlayButtonScript.gameLoader.allowSceneActivation = true;
		SceneManager.LoadScene("Game"); // this runs if the user changes their skin during the game.

	}
}
