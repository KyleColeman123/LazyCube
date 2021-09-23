using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeToRed : MonoBehaviour
{
    public Material blockMaterial;
    public Renderer rend;
    public Text cost;
    public int RedCost = 25;
    public Text currentPoints;
    public int points;
    private bool ChangeRedisExecuted = false;


    public void ChangeRed()
    {
        PlayerPrefs.SetInt("RedCostPoints", RedCost);

        if (PlayerPrefs.GetInt("Points") >= PlayerPrefs.GetInt("RedCostPoints") && cost.text != "Bought" && cost.text != "Equipeed")
        {


            cost.text = PlayerPrefs.GetString("BoughtItem");
            ChangeRedisExecuted = true;
            PlayerPrefs.SetInt("GetColorNumber", 0);
            PlayerPrefs.SetInt("OldPoints", PlayerPrefs.GetInt("OldPoints") - 25);
        }

        if (cost.text == "Bought")
        {
            PlayerPrefs.SetInt("GetColorNumber", 0);

        }

    }

    void Update()
    {
        if (ChangeRedisExecuted == true)
        {

            PlayerPrefs.SetString("BoughtItemRed", "Bought");
            cost.text = PlayerPrefs.GetString("BoughtItemRed");



        }
    }

}
