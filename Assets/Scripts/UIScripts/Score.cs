using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour
{

    public Transform Player;
    public Text scoreText;
    public int number;
    public int points;
    public int pointsNew;

    // Update is called once per frame
    void Update()
    {
        int number = (int)Player.position.z * -1;
        scoreText.text =  "Score: " + number.ToString();
        if (number > (int)PlayerPrefs.GetInt("Highscore"))
        {
            PlayerPrefs.SetInt("Highscore", number);
        }

        PlayerPrefs.SetInt("Score", number);

        points = number / 750;
        PlayerPrefs.SetInt("Points", points);
        
        PlayerPrefs.SetInt("Points", PlayerPrefs.GetInt("Points") + PlayerPrefs.GetInt("OldPoints"));


    }

    void Start()
    {
        PlayerPrefs.SetInt("OldPoints", PlayerPrefs.GetInt("Points"));
    }
}