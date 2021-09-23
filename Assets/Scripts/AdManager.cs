using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdManager : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if ((PlayerPrefs.GetInt("DeathCounter") % 3 == 0) && (PlayerPrefs.GetInt("DeathCounter") != 0)) { 
            if (Advertisement.IsReady("video"))
            {
                Advertisement.Show("video");
                PlayerPrefs.SetInt("DeathCounter", PlayerPrefs.GetInt("DeathCounter") + 1);
            }
        }
    }
}
