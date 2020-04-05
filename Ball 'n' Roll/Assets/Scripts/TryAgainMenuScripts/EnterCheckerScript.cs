using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterCheckerScript : MonoBehaviour
{
    void Update()
    {
       if(Input.GetKey(KeyCode.Return))
        {
            ScoreText.objcount = 0;
            ScoreText.cordChacker = 0;
            ScoreText.timeController2 = false;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }
}
