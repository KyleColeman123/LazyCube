using UnityEngine;

public class ScrollWithPlayerTop : MonoBehaviour
{

    public Transform player;
    public Vector3 offset;



    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(0, 12, player.position.z - 150);

    }
}
