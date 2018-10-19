using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hexagon : MonoBehaviour
{

    public float scaleSpeed = 0.1f;

    private float rotSpeed;
    private Rigidbody2D rigi;

    private void Awake()
    {
        rigi = GetComponent<Rigidbody2D>();
        rotSpeed = Random.Range(-25, 25);
        transform.localEulerAngles += new Vector3(0, 0, Random.Range(-180, 180));
    }

    private void FixedUpdate()
    {
        transform.localScale -= Vector3.one * Time.fixedDeltaTime * scaleSpeed;
        transform.localEulerAngles += new Vector3(0, 0, Time.fixedDeltaTime * rotSpeed);
        if (transform.localScale.x<0.1f)
        {
            Destroy(gameObject);
        }
    }
}
