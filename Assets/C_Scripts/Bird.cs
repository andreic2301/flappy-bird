using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public GameObject playButton;

    public float jump = 5;
    public float gravity = 9;

    public float speed = -1;

    public int rotation;

    
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
        if (rotation >= -70 && rotation <= 70)
        {
            if (speed > 0)
            {
                rotation++;
                transform.rotation = Quaternion.Euler(0, 0, rotation);
            }
            else
            {
                rotation--;
                transform.rotation = Quaternion.Euler(0, 0, rotation);
            }
        }
        else
        {
            if (rotation > 70)
            {
                rotation = 70;
            }
            else
            {
                rotation = -70;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Sky")
            return;

        if (collision.tag == "Score")
            return;

        playButton.SetActive(true);
        enabled = false;
        Time.timeScale = 0;
    }
}
