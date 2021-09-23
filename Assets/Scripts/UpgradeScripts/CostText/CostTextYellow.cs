using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CostTextYellow : MonoBehaviour
{
    public Text cost;

    // Update is called once per frame
    void Update()
    {

        cost.text = PlayerPrefs.GetString("BoughtItemYellow", "Cost: 15 points");
    }
}
