using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedBoost : MonoBehaviour
{

    public Rigidbody player;
    public Text ready;
    public int otherScore;

    void Start()
    {
        otherScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("otherScore") == 1 && player.position.z < -27)
        {
            ready.text = "Speed Boost: Ready";
            ready.color = Color.white;
        }
        else
        {
            ready.color = Color.grey;
            ready.text = "Speed Boost: Not Ready";
        }

        if ((int)(player.position.z) % 500 == 0 && player.position.z < -27 && PlayerPrefs.GetInt("otherScore") < 1)
        {
            PlayerPrefs.SetInt("otherScore", 1);
        }

    }

    public void speedBoost()
    {
        if (PlayerPrefs.GetInt("otherScore") == 1 && player.position.z < -27)
        {
            player.AddForce(0, 0, -12, ForceMode.VelocityChange);

        }

       

    }
}
