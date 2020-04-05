using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class QuitButtonScript : MonoBehaviour
{
    public Button Quit;
    public Button TryAgain;
    public Button SkinSelector;

    public GameObject selectionCanvas;
    public Transform selectionCanvasPos;
    public static Vector3 selectionCanvasPosVec = new Vector3(1.6f, 5f, 78.2f);
    public GameObject selectionPanel;
    public Transform selectionPanelPos;
    public static Vector3 selectionPanelPosVec = new Vector3(6.103f,-0.049f,78.2f);
    public GameObject yesButton;
    public Transform yesButtonPos;
    public static Vector3 yesButtonPosVec = new Vector3(-226.8f, -133.8f, 78.2f);
    public GameObject noButton;
    public Transform noButtonPos;
    public static Vector3 noButtonPosVec = new Vector3(198f, -133.8f, 78.2f);

    public void QuitFunction()
    {
        Quit.interactable = false;
        TryAgain.interactable = false;
        SkinSelector.interactable = false;

        selectionCanvasPos.position = selectionCanvasPosVec;
        Instantiate(selectionCanvas, selectionCanvasPos.position, Quaternion.identity);

        selectionPanelPos.position = selectionPanelPosVec;
        Instantiate(selectionPanel, selectionPanelPos.position, Quaternion.identity);

        yesButtonPos.position = yesButtonPosVec;
        Instantiate(yesButton, yesButtonPos.position, Quaternion.identity);

        noButtonPos.position = noButtonPosVec;
        Instantiate(noButton, noButtonPos.position, Quaternion.identity);

    }


}
