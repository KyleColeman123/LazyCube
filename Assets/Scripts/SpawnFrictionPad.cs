using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFrictionPad : MonoBehaviour
{
    public GameObject Cubeprefab;

    public Vector3 center;
    public Vector3 size;
    float elapsed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        elapsed += Time.deltaTime;
        if (elapsed >= 1f)
        {
            elapsed = elapsed % 1f;
            SpawnCube();
        }
    }

    public void SpawnCube()
    {
        center = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        Vector3 pos = center + new Vector3(1, 1, Random.Range(-size.z / 2, size.z / 2));

        Instantiate(Cubeprefab, pos, Quaternion.identity);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        Gizmos.DrawCube(center, size);
    }
}
