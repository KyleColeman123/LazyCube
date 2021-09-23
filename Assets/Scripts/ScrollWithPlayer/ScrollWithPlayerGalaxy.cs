using UnityEngine;

public class ScrollWithPlayerGalaxy : MonoBehaviour
{

    public Transform player;
    public Vector3 offset;



    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(10, 0, player.position.z * (float).92) + offset;

    }
}
