using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SleepAfterBallDestroyScript : MonoBehaviour
{

    // private void Update()
    // {
    /* if (PlayerCollision.exBool == false)
     {
         print("pesho");
         PlayerCollision.exCounter++;
         if (PlayerCollision.exCounter == 100)
         {
             PlayerCollision.exBool = true;
         }
     } */
    //  StartCoroutine("Waiter");
    // }
    IEnumerator Waiter()
    {
        if (PlayerCollision.exBool == false)
        {
            print("go6o");
            yield return new WaitForSeconds(10);
        }
    }
}
