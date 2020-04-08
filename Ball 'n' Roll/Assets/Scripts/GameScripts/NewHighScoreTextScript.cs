using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewHighScoreTextScript : MonoBehaviour
{
    public Text newHighScore;
    public static int highScoreCounter = 0;
    void Update()
    {
        if(ScoreText.newHighScore == true)
        {
            if(highScoreCounter < 185)
            {
                newHighScore.text = "New High Score!!!";
            }
            if(highScoreCounter == 185)
            {
                ScoreText.newHighScore = false;
                newHighScore.text = "";
                highScoreCounter = 0;
            }
            highScoreCounter++;
        }
    }
}
