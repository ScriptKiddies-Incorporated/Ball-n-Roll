using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentBestScore : MonoBehaviour
{
    public Text CurrentBestScore1;
    public static int bestScore = 0;
    void Update()
    {
        if (ScoreText.score > bestScore)
        {
            CurrentBestScore1.text = "Your current best score is: " + ScoreText.score.ToString("0");
            bestScore = ScoreText.score;
        }
        else
        {
            CurrentBestScore1.text = "Your current best score is: " + bestScore.ToString("0");
        }
    }
}
