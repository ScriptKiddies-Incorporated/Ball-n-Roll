using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    public Transform BallPlayerPos;
    public Text scoreText;
    public static int score;
    public static int objCount = 0;
    public static bool timeController2 = true;
    public static int cordChecker = 0;
	public GameObject wow;
	public static bool hasPlayed = false;
    public static bool newHighScore = false;
    public GameObject ballPlayerNull2;

	void Start()
	{
		hasPlayed = false;
	}

	void Update()
    {
        if (ballPlayerNull2 != null)
        {
            if (timeController2 == false)
            {
                score = 0;
                scoreText.text = score.ToString("0");
                timeController2 = true;
            }

            if (int.Parse(BallPlayerPos.position.z.ToString("0")) % 7 == 0 && int.Parse(BallPlayerPos.position.z.ToString("0")) != 0 && int.Parse(BallPlayerPos.position.z.ToString("0")) != -1)
            {
                if (cordChecker != int.Parse(BallPlayerPos.position.z.ToString("0")))
                {
                    objCount++;
                    cordChecker = int.Parse(BallPlayerPos.position.z.ToString("0"));
                }
            }
            if (objCount == 5)
            {
                score++;
                objCount = 0;
            }

            scoreText.text = score.ToString("0");

            if (ScoreText.score > CurrentBestScore.bestScore)
            {


                if (!hasPlayed)
                {
                    Instantiate(wow);
                    newHighScore = true;
                    hasPlayed = true;
                }
            }
        }
	}
    }

