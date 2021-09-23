using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YourCurrentScore : MonoBehaviour
{
    public Text yourScoreText;
    public int number;

    void Update()
    {

        number = (int)PlayerPrefs.GetInt("Score");
        yourScoreText.text = "Your Current Score: " + number.ToString();

    }
}
