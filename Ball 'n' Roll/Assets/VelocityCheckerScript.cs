using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VelocityCheckerScript : MonoBehaviour
{
    public static int secTimeCounter = 0;
    public static int timeCounter = 0;
    public static float zVelOperator;
    public Transform ballVelPos;
    public Text velText;
    void Update()
    {
        secTimeCounter++;
        zVelOperator = ballVelPos.position.z;
      //  if(secTimeCounter == 60)
      //  {
        //    timeCounter++;
            velText.text = (Mathf.Abs(zVelOperator)/secTimeCounter).ToString();
        //    secTimeCounter = 0;
       // }
    }
}
