using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToUpgrades : MonoBehaviour
{

    public Canvas upgradeCanvas;
    public Canvas pauseCanvas;

    public void goToUpgrades()
    {

        upgradeCanvas.gameObject.SetActive(!upgradeCanvas.gameObject.activeSelf);
        //RedBox.constraints = RigidbodyConstraints.FreezePositionZ;
        pauseCanvas.gameObject.SetActive(!pauseCanvas.gameObject.activeSelf);

    }
}