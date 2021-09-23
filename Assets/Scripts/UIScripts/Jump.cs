using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{

    public Rigidbody player;


    public void PlayerJump()
    {


        player.AddForce(0, 1500, 0);


    }
}
