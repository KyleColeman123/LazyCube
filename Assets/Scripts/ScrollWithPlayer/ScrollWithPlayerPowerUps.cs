using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollWithPlayerPowerUps : MonoBehaviour
{
    public Transform player;
    public Rigidbody spawner; 
    public Vector3 offset;
    float elapsed = 0f;
    float currentSpeed = -300f;


    // Update is called once per frame
    void Update()
    {

        spawner.AddForce(0, 0, currentSpeed * Time.deltaTime);
        elapsed += Time.deltaTime;
        if (elapsed >= 1f)
        {
            elapsed = elapsed % 1f;
            currentSpeed -= 1;
        }


    }
}
