using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeToPurple : MonoBehaviour
{
    public Material blockMaterial;
    public Renderer rend;
    public Text cost;
    public int PurpleCost = 20;
    public Text currentPoints;
    public int points;
    private bool ChangePurpleisExecuted = false;


    public void ChangePurple()
    {
        PlayerPrefs.SetInt("PurpleCostPoints", PurpleCost);

        if (PlayerPrefs.GetInt("Points") >= PlayerPrefs.GetInt("PurpleCostPoints") && cost.text != "Bought" && cost.text != "Equipped")
        {


            cost.text = PlayerPrefs.GetString("BoughtItem");
            ChangePurpleisExecuted = true;
            PlayerPrefs.SetInt("GetColorNumber", 5);
            PlayerPrefs.SetInt("OldPoints", PlayerPrefs.GetInt("OldPoints") - 20);
        }

        if (cost.text == "Bought")
        {
            PlayerPrefs.SetInt("GetColorNumber", 5);
        }

    }

    void Update()
    {
        if (ChangePurpleisExecuted == true)
        {

            PlayerPrefs.SetString("BoughtItemPurple", "Bought");
            cost.text = PlayerPrefs.GetString("BoughtItemPurple");



        }
    }

}
