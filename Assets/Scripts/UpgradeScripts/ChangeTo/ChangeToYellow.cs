using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeToYellow : MonoBehaviour
{
    public Material blockMaterial;
    public Renderer rend;
    public Text cost;
    public int YellowCost = 15;
    public Text currentPoints;
    public int points;
    private bool ChangeYellowisExecuted = false;


    public void ChangeYellow()
    { 
    PlayerPrefs.SetInt("YellowCostPoints", YellowCost);

        if (PlayerPrefs.GetInt("Points") >= PlayerPrefs.GetInt("YellowCostPoints") && cost.text != "Bought" && cost.text != "Equipeed")
        {


            cost.text = PlayerPrefs.GetString("BoughtItem");
            ChangeYellowisExecuted = true;
            PlayerPrefs.SetInt("GetColorNumber", 3);
            PlayerPrefs.SetInt("OldPoints", PlayerPrefs.GetInt("OldPoints") - 15);
        }

        if (cost.text == "Bought")
        {
            PlayerPrefs.SetInt("GetColorNumber", 3);
        }

    }

    void Update()
{
    if (ChangeYellowisExecuted == true)
    {

        PlayerPrefs.SetString("BoughtItemYellow", "Bought");
        cost.text = PlayerPrefs.GetString("BoughtItemYellow");



    }
}
   
}
