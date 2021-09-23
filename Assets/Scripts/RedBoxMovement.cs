using UnityEngine;

public class RedBoxMovement : MonoBehaviour
{
    public Rigidbody rb;
    float currentSpeed = -175f;
    float elapsed = 0f;
    public AudioSource hitEffect;
    public Material blockMaterial;
    public Renderer rend;
    public Color[] playerColors = new Color[10];
    //public Material[] playerColors1 = new Material[10];

    // Update is called once per frame
    void FixedUpdate()
    {
        rend.material.color = playerColors[PlayerPrefs.GetInt("GetColorNumber", 9)];

        rb.AddForce(0, 0, currentSpeed * Time.deltaTime);
        elapsed += Time.deltaTime;
        if (elapsed >= 1f)
        {
            elapsed = elapsed % 1f;
            currentSpeed--;
        }

        float x = rb.position.x;
        float y = rb.position.y;
        float z = rb.position.z;

        if(rb.position.x != 0)
        {
            rb.position = new Vector3(0,y,z);
        }


        rb.AddForce(0, -4000 * Time.deltaTime, 0);

        if (rb.position.y > 3.5 && rb.position.z > -500)
        {
            rb.drag = (float).11F;
        }
        if (rb.position.y > 3.5 && rb.position.z < -500 && rb.position.z > -1000)
        {
            rb.drag = (float).12F;
        }
        if (rb.position.y > 3.5 && rb.position.z < -1000 && rb.position.z > -5000)
        {
            rb.drag = (float).13F;
        }
        if (rb.position.y > 3.5 && rb.position.z < -5000)
        {
            rb.drag = (float).16F;
        }

        if (rb.velocity.z < -130.0)
        {
            rb.drag = .15F;
        }
        if (rb.velocity.z > -130.0 && rb.position.y < 2.5)
        {
            rb.drag = 0F;
        }

    }

    public void OnCollisionEnter()
    {
        hitEffect.Play();

    }

}
    
