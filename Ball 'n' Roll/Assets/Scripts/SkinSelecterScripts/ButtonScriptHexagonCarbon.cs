using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScriptHexagonCarbon : MonoBehaviour
{
    public static string skinChoice;
    public void ButtonscriptHexagonCarbon()
    {
        ScoreText.objcount = 0;
        ScoreText.cordChacker = 0;
        ScoreText.timeController2 = false;
        skinChoice = "HexagonCarbon";
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

}
