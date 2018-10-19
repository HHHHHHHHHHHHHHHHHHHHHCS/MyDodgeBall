using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float moveSpeed = 600f;
    public float timeScaleRate = 0.01f;

    private int dir;

    private void Awake()
    {
        Time.timeScale = 1;
    }

    private void Update()
    {
        if (Time.timeScale == 0)
        {
            if(Input.GetKeyDown(KeyCode.Escape))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
        else
        {
            Time.timeScale += Time.fixedDeltaTime * timeScaleRate;
        }

        if (Input.GetKey(KeyCode.A))
        {
            dir = 1;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            dir = -1;
        }
        else
        {
            dir = 0;
        }
 
    }

    private void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward
            , moveSpeed * Time.fixedDeltaTime * dir);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Time.timeScale = 0;
        }
    }

}
