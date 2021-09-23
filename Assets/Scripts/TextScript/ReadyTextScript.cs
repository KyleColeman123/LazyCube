using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReadyTextScript : MonoBehaviour
{

    public Text ready;
    public Rigidbody player;

    void Update()
    {
        if (player.position.z > -18)
        {
            ready.enabled = true;
        }
        else ready.enabled = false;
    }
}
