using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPowerUp : MonoBehaviour
{
    public Rigidbody player;
    public Rigidbody powerupRB;
    public GameObject powerupGO;

    // Update is called once per frame
    void Update()
    {
        if (player.position.z - powerupRB.position.z <= -7)
        {
            Destroy(powerupGO);
        }
    }
}
