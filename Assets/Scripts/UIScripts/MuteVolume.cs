using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MuteVolume : MonoBehaviour
{

    public AudioSource music;
    public Text mutedText;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (PlayerPrefs.GetInt("Volume") % 2 != 0)
        {
            mutedText.text = "Music:  Muted";
            music.volume = 0;
        }
        else
        {
            mutedText.text = "Music:  Not Muted";
            music.volume = 1;
        }
        Debug.Log(PlayerPrefs.GetInt("Volume"));
    }
}
