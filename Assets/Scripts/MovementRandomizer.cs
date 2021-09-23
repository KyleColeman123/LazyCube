using UnityEngine;

public class MovementRandomizer : MonoBehaviour
{

    public Rigidbody rb;
    float currentSpeed = -100f;
    float targetSpeed = -900f;

    // Update is called once per frame
    void FixedUpdate()
    {

        if (currentSpeed < targetSpeed)
        {
            currentSpeed += Time.deltaTime;
        }
        rb.AddForce(0, 0, currentSpeed * Time.deltaTime);
    }
}