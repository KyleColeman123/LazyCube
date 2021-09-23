using UnityEngine;

public class ScrollWithPlayerBottom : MonoBehaviour
{

    public Transform player;
    public Vector3 offset;
    
    

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(-2, -2, player.position.z - 150);
        
    }
}
