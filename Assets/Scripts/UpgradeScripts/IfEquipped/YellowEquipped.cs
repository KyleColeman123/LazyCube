using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YellowEquipped : MonoBehaviour
{

    public Text equippedText;
    public Text boughtText;

    // Update is called once per frame
    void Update()
    {

        if ((PlayerPrefs.GetInt("GetColorNumber") == 3) && (boughtText.text == "Bought"))
        {
            PlayerPrefs.SetString("Equipped", "Equipped");
        }
        else
        {
            PlayerPrefs.SetString("Equipped", "Unequipped");
        }
        equippedText.text = PlayerPrefs.GetString("Equipped");
    }
}
