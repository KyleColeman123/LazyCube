using UnityEngine;

public class FollowCamera : MonoBehaviour
{

    public Transform camera;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(camera.position.x, camera.position.y/10, camera.position.z) + offset;
    }
}
