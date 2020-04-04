using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreBoard : MonoBehaviour
{
    public Text Finalscore;
    void Update()
    {
        Finalscore.text = "Your score is: " + ScoreText.score.ToString("0");
    }
}
