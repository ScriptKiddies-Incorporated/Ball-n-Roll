using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScriptBones : MonoBehaviour
{

    public void ButtonscriptBones()
    {
       ButtonScriptHexagonCarbon.skinChoice = "Bones";
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
