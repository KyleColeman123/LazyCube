using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YourHighScore : MonoBehaviour
{
    public Text yourHighScoreText;
    public int number;

    void Update()
    {

        number = (int)PlayerPrefs.GetInt("Highscore");
        yourHighScoreText.text = "Your High Score: " + number.ToString();

    }
}
