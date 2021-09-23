using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resume : MonoBehaviour
{
    public Canvas pauseCanvas;
    public Rigidbody RedBox;

    public void resumeGame()
    {
        if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
            pauseCanvas.gameObject.SetActive(false);
            AudioListener.volume = 1;
            RedBox.constraints = RigidbodyConstraints.None;
        }
        Debug.Log(Time.timeScale);

    }
}
