using UnityEngine;

public class ScrollWithPlayerBack : MonoBehaviour
{

    public Transform player;
    public Vector3 offset;



    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(3, 4, player.position.z - 150);

    }
}