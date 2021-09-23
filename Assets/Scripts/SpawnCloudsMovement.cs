using UnityEngine;

public class SpawnCloudsMovement : MonoBehaviour
{
    public Rigidbody item;
    float currentSpeed = -50f;
    float elapsed = 0f;
    
    // Update is called once per frame
    void Update()
    {

        item.AddForce(0, 0, currentSpeed * Time.deltaTime);
        elapsed += Time.deltaTime;
        if (elapsed >= 1f)
        {
            elapsed = elapsed % 1f;
            currentSpeed--;
        }
        

        /*if (Input.GetMouseButtonDown(0))  //player controls
        {
             rb.AddForce(0, 1500, 0);
        }
        else rb.AddForce(0, -4000 * Time.deltaTime, 0);
        */
    }
}
    
