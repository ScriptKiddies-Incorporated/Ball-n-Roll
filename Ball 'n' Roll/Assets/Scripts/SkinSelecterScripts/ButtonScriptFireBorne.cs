using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScriptFireBorne : MonoBehaviour
{

    public void ButtonscriptFireBorne()
    {
        ScoreText.objCount = 0;
        ScoreText.cordChecker = 0;
        ScoreText.timeController2 = false;
        ButtonScriptHexagonCarbon.skinChoice = "FireBorne";
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
}
