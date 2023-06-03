using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public float speed = 2;
    void Update()
    {
        transform.position -= new Vector3(speed * Time.deltaTime, 0);
        if (transform.position.x < -10)
        {
            Destroy(gameObject);
        }
    }
}
