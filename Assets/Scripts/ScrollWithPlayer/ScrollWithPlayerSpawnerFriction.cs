using UnityEngine;

public class ScrollWithPlayerSpawnerFriction : MonoBehaviour
{

    public Transform player;
    public Vector3 offset;
    

    // Update is called once per frame
    void Update()
    {

        transform.position = new Vector3(-3, -6, player.position.z - 100);
        
    }
}
