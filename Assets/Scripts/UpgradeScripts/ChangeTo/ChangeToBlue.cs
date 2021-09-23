using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeToBlue : MonoBehaviour
{
    public Material blockMaterial;
    public Renderer rend;
    public Text cost;
    public int BlueCost = 25;
    public Text currentPoints;
    public int points;
    private bool ChangeBlueisExecuted = false;


    public void ChangeBlue()
    {
        PlayerPrefs.SetInt("BlueCostPoints", BlueCost);

        if (PlayerPrefs.GetInt("Points") >= PlayerPrefs.GetInt("BlueCostPoints") && cost.text != "Bought" && cost.text != "Equipeed" )
        {


            cost.text = PlayerPrefs.GetString("BoughtItem");
            ChangeBlueisExecuted = true;
            PlayerPrefs.SetInt("GetColorNumber", 1);
            PlayerPrefs.SetInt("OldPoints", PlayerPrefs.GetInt("OldPoints") - 25);
        }

        if (cost.text == "Bought")
        {
            PlayerPrefs.SetInt("GetColorNumber", 1);
        }

    }

    void Update()
    {
        if (ChangeBlueisExecuted == true)
        {

            PlayerPrefs.SetString("BoughtItemBlue", "Bought");
            cost.text = PlayerPrefs.GetString("BoughtItemBlue");



        }
    }

}
