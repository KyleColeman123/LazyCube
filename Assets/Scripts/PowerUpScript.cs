using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpScript : MonoBehaviour
{
    public Rigidbody powerupRB;
    public GameObject powerupGO;
    public Rigidbody player;



    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        player.AddForce(0, 0, -30, ForceMode.VelocityChange);
        powerupRB.position = new Vector3(50, 0, 0);
        Debug.Log("COOL");
        
    }
}
