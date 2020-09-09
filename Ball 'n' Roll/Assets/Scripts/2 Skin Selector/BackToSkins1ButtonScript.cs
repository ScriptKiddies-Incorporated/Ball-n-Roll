using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToSkins1ButtonScript : MonoBehaviour
{
    public void BackToSkins1()
    {
        SceneManager.LoadScene("SkinSelecter");
    }
}
