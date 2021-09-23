using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Volume : MonoBehaviour
{

    public GameObject music;

    public void VolumeChanger()
    {

            PlayerPrefs.SetInt("Volume", PlayerPrefs.GetInt("Volume") + 1);

    }


}
