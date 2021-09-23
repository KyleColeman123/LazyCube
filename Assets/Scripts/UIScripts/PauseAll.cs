using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseAll : MonoBehaviour
{

    public Canvas pauseCanvas;
    public Rigidbody RedBox;

    public void PauseGame()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            AudioListener.volume = 0;
            pauseCanvas.gameObject.SetActive(!pauseCanvas.gameObject.activeSelf);

         }
        else
        {
            Time.timeScale = 1;
            AudioListener.volume = 1;
        }
    }
}