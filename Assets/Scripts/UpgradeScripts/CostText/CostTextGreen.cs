using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CostTextGreen : MonoBehaviour
{
    public Text cost;

    // Update is called once per frame
    void Update()
    {

        cost.text = PlayerPrefs.GetString("BoughtItemGreen", "Cost: 15 points");
    }
}

