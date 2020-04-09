using UnityEngine;
using UnityEngine.SceneManagement;

public class TryAgainButtonScript : MonoBehaviour
{
    public void TryAgain()
    {
        ScoreText.objCount = 0;
        ScoreText.cordChecker = 0;
        VelocityCheckerScript.timeCounter = 0;
        VelocityCheckerScript.secTimeCounter = 0;
        ScoreText.timeController2 = false;
        PlayerCollision.exBool = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
