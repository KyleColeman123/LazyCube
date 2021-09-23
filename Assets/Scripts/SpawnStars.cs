﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnStars : MonoBehaviour
{
    public GameObject Cubeprefab;

    public Vector3 center;
    public Vector3 size;
    public Vector3 rotation;
  
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
        Vector3 pos = center + new Vector3(1, Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.z / 2));

        Instantiate(Cubeprefab, pos, Quaternion.Euler(new Vector3(0, 90, 0)));

    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        Gizmos.DrawCube(center, size);
    }
}

