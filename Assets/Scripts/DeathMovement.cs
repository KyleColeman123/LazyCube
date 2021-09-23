using UnityEngine;

public class DeathMovement : MonoBehaviour
{

    public Rigidbody rb;
    float currentSpeed = -30f;
    float targetSpeed = -26f;
    float elapsed = 0f;

    // Update is called once per frame
    void FixedUpdate()
    {

        rb.AddForce(0, 0, currentSpeed * Time.deltaTime);
        elapsed += Time.deltaTime;
        if (elapsed >= 1f)
        {
            elapsed = elapsed % 1f;
            currentSpeed -=(float).225;
        }
        if (rb.velocity.z < -120.0)
        {
            rb.drag = .1F;
        }
        if (rb.velocity.z > -120.0)
        {
            rb.drag = 0F;
        }
    }
}