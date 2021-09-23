using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public Text highscoreText;
    public int number;

    void Start()
    {
       
        number = (int)PlayerPrefs.GetInt("Highscore");
        highscoreText.text = "High Score: " + number.ToString();
        
    }
}

