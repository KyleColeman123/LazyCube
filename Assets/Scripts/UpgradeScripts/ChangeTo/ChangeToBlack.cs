using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeToBlack : MonoBehaviour
{
    public Material blockMaterial;
    public Renderer rend;
    public Text cost;
    public int BlackCost = 20;
    public Text currentPoints;
    public int points;
    private bool ChangeBlackisExecuted = false;


    public void ChangeBlack()
    {
        PlayerPrefs.SetInt("BlackCostPoints", BlackCost);

        if (PlayerPrefs.GetInt("Points") >= PlayerPrefs.GetInt("BlackCostPoints") && cost.text != "Bought" && cost.text != "Equipped")
        {


            cost.text = PlayerPrefs.GetString("BoughtItem");
            ChangeBlackisExecuted = true;
            PlayerPrefs.SetInt("GetColorNumber", 7);
            PlayerPrefs.SetInt("OldPoints", PlayerPrefs.GetInt("OldPoints") - 20);
        }

        if (cost.text == "Bought")
        {
            PlayerPrefs.SetInt("GetColorNumber", 7);
        }

    }

    void Update()
    {
        if (ChangeBlackisExecuted == true)
        {

            PlayerPrefs.SetString("BoughtItemBlack", "Bought");
            cost.text = PlayerPrefs.GetString("BoughtItemBlack");



        }
    }

}
