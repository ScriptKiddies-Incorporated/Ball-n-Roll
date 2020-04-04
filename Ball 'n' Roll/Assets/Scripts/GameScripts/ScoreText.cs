using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    public Transform BallPlayerPos;
    public Text scoretext;
    public double accdivider = 2;
    public static int score;
    public static int objcount = 0;
    public static bool timeController2 = true;
    public static int cordChacker = 0;

    void Update()
    {

            if (timeController2 == false)
            {
                score = 0;
                scoretext.text = score.ToString("0");
                timeController2 = true;
            }

            if (int.Parse(BallPlayerPos.position.z.ToString("0")) % 7 == 0 && int.Parse(BallPlayerPos.position.z.ToString("0")) != 0 && int.Parse(BallPlayerPos.position.z.ToString("0")) != -1)
            {
                if (cordChacker != int.Parse(BallPlayerPos.position.z.ToString("0")))
                {
                    objcount = objcount + 1;
                    cordChacker = int.Parse(BallPlayerPos.position.z.ToString("0"));
                }
            }
            if (objcount == 5)
            {
                score = score + 1;
                objcount = 0;
            }

            scoretext.text = score.ToString("0");

      }
    }

