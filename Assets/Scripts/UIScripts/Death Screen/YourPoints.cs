using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YourPoints : MonoBehaviour
{

    public Text points;
    public int number;

    void Update()
    {
        number = (int)PlayerPrefs.GetInt("Points");
        points.text = "Points: " + number.ToString();
    }
}
