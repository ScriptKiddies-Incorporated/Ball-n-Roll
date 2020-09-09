using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NoButtonScript : MonoBehaviour
{

    public static string name0 = "YouWantToQuit?Canvas(Clone)";
    public static string name1 = "YesButton(Clone)";
    public static string name2 = "NoButton(Clone)";
    public static string name3 = "YouWantToQuit?Panel(Clone)";

    public void OnPressNoButton()
    {


        GameObject go = GameObject.Find(name0);
        GameObject go1 = GameObject.Find(name1);
        GameObject go2 = GameObject.Find(name2);
        GameObject go3 = GameObject.Find(name3);
        Destroy(go.gameObject);
        Destroy(go1.gameObject);
        Destroy(go2.gameObject);
        Destroy(go3.gameObject);
        PlayerCollision.redSoundCondition = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
