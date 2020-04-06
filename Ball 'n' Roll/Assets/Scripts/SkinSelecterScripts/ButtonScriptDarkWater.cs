using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScriptDarkWater : MonoBehaviour
{
    public void ButtonscriptDarkWater()
    {
        ScoreText.objCount = 0;
        ScoreText.cordChecker = 0;
        ScoreText.timeController2 = false;
        ButtonScriptHexagonCarbon.skinChoice = "DarkWater";
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
}
