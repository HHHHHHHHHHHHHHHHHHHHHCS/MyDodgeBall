using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float spawnRate = 1f;
    public GameObject hexagonPrefab;

    private float nextTimer=1f;

    private void FixedUpdate()
    {
        nextTimer -= Time.fixedDeltaTime;
        if (nextTimer<=0)
        {
            Instantiate(hexagonPrefab);
            nextTimer = spawnRate;
        }
    }

}
