using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrivacyPolicy : MonoBehaviour
{
    public void GoToPrivacyPolicy()
    {
        Application.OpenURL("https://unity3d.com/legal/privacy-policy");
    }
}
