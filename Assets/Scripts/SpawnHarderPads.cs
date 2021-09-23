using UnityEngine;

public class SpawnHarderPads : MonoBehaviour
{
    public Rigidbody item;
    float currentSpeed = -500f;
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



    }
}
