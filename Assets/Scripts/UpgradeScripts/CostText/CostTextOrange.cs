using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CostTextOrange : MonoBehaviour
{
    public Text cost;

    // Update is called once per frame
    void Update()
    {

        cost.text = PlayerPrefs.GetString("BoughtItemOrange", "Cost: 20 points");
    }
}
