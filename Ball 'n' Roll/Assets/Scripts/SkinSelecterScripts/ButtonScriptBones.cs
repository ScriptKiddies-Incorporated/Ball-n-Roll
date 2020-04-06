using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScriptBones : MonoBehaviour
{

    public void ButtonscriptBones()
    {
        ScoreText.objCount = 0;
        ScoreText.cordChecker = 0;
        ScoreText.timeController2 = false;
        ButtonScriptHexagonCarbon.skinChoice = "Bones";
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
