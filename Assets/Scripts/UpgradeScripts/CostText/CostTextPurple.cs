using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CostTextPurple : MonoBehaviour
{
    public Text cost;

    // Update is called once per frame
    void Update()
    {

        cost.text = PlayerPrefs.GetString("BoughtItemPurple", "Cost: 20 points");
    }
}

