using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeToOrange : MonoBehaviour
{
    public Material blockMaterial;
    public Renderer rend;
    public Text cost;
    public int OrangeCost = 20;
    public Text currentPoints;
    public int points;
    private bool ChangeOrangeisExecuted = false;


    public void ChangeOrange()
    {
        PlayerPrefs.SetInt("OrangeCostPoints", OrangeCost);

        if (PlayerPrefs.GetInt("Points") >= PlayerPrefs.GetInt("OrangeCostPoints") && cost.text != "Bought" && cost.text != "Equipped")
        {


            cost.text = PlayerPrefs.GetString("BoughtItem");
            ChangeOrangeisExecuted = true;
            PlayerPrefs.SetInt("GetColorNumber", 4);
            PlayerPrefs.SetInt("OldPoints", PlayerPrefs.GetInt("OldPoints") - 20);
        }

        if (cost.text == "Bought")
        {
            PlayerPrefs.SetInt("GetColorNumber", 4);
        }

    }

    void Update()
    {
        if (ChangeOrangeisExecuted == true)
        {

            PlayerPrefs.SetString("BoughtItemOrange", "Bought");
            cost.text = PlayerPrefs.GetString("BoughtItemOrange");



        }
    }

}
