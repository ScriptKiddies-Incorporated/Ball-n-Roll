using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreBoard : MonoBehaviour
{
    public Text finalScore;
    public static int varScore;
    private void Start()
    {
        varScore = ScoreText.score;
    }
    void Update()
    {
        finalScore.text = "Your Score: " + varScore.ToString("0");
    }
}
