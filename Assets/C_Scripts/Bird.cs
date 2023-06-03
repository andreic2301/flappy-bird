using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public GameObject playButton;

    public float jump = 5;
    public float gravity = 9;

    float speed = -1;

    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            speed = jump;
        }
        else
        {
            speed -= Time.deltaTime * gravity;
        }

        transform.position += new Vector3(0, speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Sky")
            return;

        if (collision.tag == "Score")
            return;

        playButton.SetActive(true);
        Time.timeScale = 0;
    }
}
