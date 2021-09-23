using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeToGreen : MonoBehaviour
{
    public Material blockMaterial;
    public Renderer rend;
    public Text cost;
    public int GreenCost = 15;
    public Text currentPoints;
    public int points;
    private bool ChangeGreenisExecuted = false;


    public void ChangeGreen()
    {
        PlayerPrefs.SetInt("GreenCostPoints", GreenCost);

        if (PlayerPrefs.GetInt("Points") >= PlayerPrefs.GetInt("GreenCostPoints") && cost.text != "Bought" && cost.text != "Equipeed")
        {


            cost.text = PlayerPrefs.GetString("BoughtItem");
            ChangeGreenisExecuted = true;
            PlayerPrefs.SetInt("GetColorNumber", 2);
            PlayerPrefs.SetInt("OldPoints", PlayerPrefs.GetInt("OldPoints") - 15);
        }

        if (cost.text == "Bought")
        {
            PlayerPrefs.SetInt("GetColorNumber", 2);
        }

    }

    void Update()
    {
        if (ChangeGreenisExecuted == true)
        {

            PlayerPrefs.SetString("BoughtItemGreen", "Bought");
            cost.text = PlayerPrefs.GetString("BoughtItemGreen");



        }
    }

}
