using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{
    public Canvas YouDiedCanvas;
    public AudioSource song;
    

    public void retryGame()
    {
        SceneManager.LoadScene("MainSceneLazyCube");
        Time.timeScale = 1;
        song.Play();
        AudioListener.volume = 1;
    }
}
