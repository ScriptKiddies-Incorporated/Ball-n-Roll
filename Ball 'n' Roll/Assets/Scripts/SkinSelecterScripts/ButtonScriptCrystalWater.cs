using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScriptCrystalWater : MonoBehaviour
{
    public void ButtonscriptCrystalWater()
    {
        ScoreText.objCount = 0;
        ScoreText.cordChecker = 0;
        ScoreText.timeController2 = false;
        ButtonScriptHexagonCarbon.skinChoice = "CrystalWater";
		// SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		PlayButtonScript.gameLoader.allowSceneActivation = true;
		SceneManager.LoadScene("Game"); // this runs if the user changes their skin during the game.

	}
}
