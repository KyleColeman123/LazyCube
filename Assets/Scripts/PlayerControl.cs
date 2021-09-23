using UnityEngine;

public class PlayerControls : MonoBehaviour { 

    public Rigidbody rb;

    public float jumpForce = 500f;



    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            rb.AddForce(0, 500 * Time.deltaTime, 0);
        }
       
    }


}
