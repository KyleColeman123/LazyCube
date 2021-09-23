using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpNew : MonoBehaviour
{

    public Rigidbody player;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && Time.timeScale == 1)
        {
            player.AddForce(0, 800, 0,ForceMode.Acceleration);
        }
    }
}
