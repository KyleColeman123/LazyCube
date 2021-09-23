using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GOTextScript : MonoBehaviour
{

    public Text ready;
    public Text go;
    public Rigidbody player;

    void Update()
    {
        if (player.position.z < -18 && player.position.z > -28)
        {
            ready.enabled = false;
            go.enabled = true;
        }
        else go.enabled = false;
    }
}
