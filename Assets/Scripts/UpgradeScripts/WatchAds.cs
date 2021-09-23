using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class WatchAds : MonoBehaviour
{
    public void PlayAd()
    {
       if (Advertisement.IsReady("rewardedVideo"))
            {
                Advertisement.Show("rewardedVideo");
                PlayerPrefs.SetInt("OldPoints", PlayerPrefs.GetInt("Points") + 1);
        }
       }

}
