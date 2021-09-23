using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButtonDeath : MonoBehaviour
{

    public Canvas deathCanvas;
    public Canvas currentCanvas;

    public void goBackToDeath()
    {
        deathCanvas.gameObject.SetActive(!deathCanvas.gameObject.activeSelf);
        currentCanvas.gameObject.SetActive(!currentCanvas.gameObject.activeSelf);
    }


}