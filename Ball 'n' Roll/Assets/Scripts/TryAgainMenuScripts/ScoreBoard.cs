using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreBoard : MonoBehaviour
{
    public Text finalScore;
    void Update()
    {
        finalScore.text = "Your score is: " + ScoreText.score.ToString("0");
    }
}
