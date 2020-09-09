using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScriptFlamingoPink : MonoBehaviour
{
    public void ButtonscriptFlamingoPink()
    {
        ScoreText.objCount = 0;
        ScoreText.cordChecker = 0;
        ScoreText.timeController2 = false;
        ButtonScriptHexagonCarbon.skinChoice = "FlamingoPink";
       // PlayButtonScript.gameLoader.allowSceneActivation = true;
        SceneManager.LoadScene("Game"); // this runs if the user changes their skin during the game
    }
}
