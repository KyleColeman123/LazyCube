using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeToSkyBlue : MonoBehaviour
{
    public Material blockMaterial;
    public Renderer rend;
    public Text cost;
    public int SkyBlueCost = 20;
    public Text currentPoints;
    public int points;
    private bool ChangeSkyBlueisExecuted = false;


    public void ChangeSkyBlue()
    {
        PlayerPrefs.SetInt("SkyBlueCostPoints", SkyBlueCost);

        if (PlayerPrefs.GetInt("Points") >= PlayerPrefs.GetInt("SkyBlueCostPoints") && cost.text != "Bought" && cost.text != "Equipped")
        {


            cost.text = PlayerPrefs.GetString("BoughtItem");
            ChangeSkyBlueisExecuted = true;
            PlayerPrefs.SetInt("GetColorNumber", 6);
            PlayerPrefs.SetInt("OldPoints", PlayerPrefs.GetInt("OldPoints") - 20);
        }

        if (cost.text == "Bought")
        {
            PlayerPrefs.SetInt("GetColorNumber", 6);
        }

    }

    void Update()
    {
        if (ChangeSkyBlueisExecuted == true)
        {

            PlayerPrefs.SetString("BoughtItemSkyBlue", "Bought");
            cost.text = PlayerPrefs.GetString("BoughtItemSkyBlue");



        }
    }

}