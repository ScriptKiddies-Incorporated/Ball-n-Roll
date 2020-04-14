using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScriptAvatarBitcoin : MonoBehaviour
{
    public void ButtonscriptAvatarBitcoin()
    {
        ScoreText.objCount = 0;
        ScoreText.cordChecker = 0;
        ScoreText.timeController2 = false;
        ButtonScriptHexagonCarbon.skinChoice = "AvatarBitcoin";
       // PlayButtonScript.gameLoader.allowSceneActivation = true;
        SceneManager.LoadScene("Game"); // this runs if the user changes their skin during the game
    }
}
