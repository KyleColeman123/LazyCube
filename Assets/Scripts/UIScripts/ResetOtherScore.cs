using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetOtherScore : MonoBehaviour
{
public void resetOtherScore()
    {
        if (PlayerPrefs.GetInt("otherScore") == 1)
        {
            PlayerPrefs.SetInt("otherScore", PlayerPrefs.GetInt("otherScore") - 1);
        }
            Debug.Log(PlayerPrefs.GetInt("otherScore"));
    }
}
