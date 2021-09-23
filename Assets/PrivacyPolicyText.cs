using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrivacyPolicyText : MonoBehaviour
{
    public GameObject policyCanvas;

    public void ShowPolicy()
    {
        policyCanvas.gameObject.SetActive(!policyCanvas.gameObject.activeSelf);

    }
}
