using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScriptHexagonCarbon : MonoBehaviour
{
    public static string skinChoice;
    public void ButtonscriptHexagonCarbon()
    {
        skinChoice = "HexagonCarbon";
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

}
