using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScriptGoldenRain : MonoBehaviour
{
    public void ButtonscriptGoldenRain()
    {
        ScoreText.objCount = 0;
        ScoreText.cordChecker = 0;
        ScoreText.timeController2 = false;
        ButtonScriptHexagonCarbon.skinChoice = "GoldenRain";
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
}
