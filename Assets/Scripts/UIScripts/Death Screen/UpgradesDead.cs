using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UpgradesDead : MonoBehaviour
{

    public Canvas upgradeCanvas;
    public Canvas currentCanvas;

    public void goUprgrades()
    {
        upgradeCanvas.gameObject.SetActive(!upgradeCanvas.gameObject.activeSelf);
        currentCanvas.gameObject.SetActive(!currentCanvas.gameObject.activeSelf);
    }


}
