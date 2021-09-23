using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathDistance : MonoBehaviour
{
    public Rigidbody death;
    public Rigidbody player;
    public Text deathDistance;




    void Update()
    {
        int distance = (int)(player.position.z - death.position.z - 37)*-1;
        deathDistance.text = "Death Distance: " + distance.ToString();
        if (distance < 100)
        {
            deathDistance.color = Color.red;
        }

        else deathDistance.color = Color.green;
    }
}
