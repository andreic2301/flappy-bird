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

    public AudioSource Wing_Sound;
    public AudioSource Death_Sound;

    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Wing_Sound.Play();
            speed = jump;
        }
        else
        {
            speed -= Time.deltaTime * gravity;
        }

        transform.position += new Vector3(0, speed * Time.deltaTime);
        transform.rotation = Quaternion.Euler(0, 0, Mathf.Clamp(speed * 9, -45, 45));
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
        GameObject.Find("Background").GetComponent<AudioSource>().Stop();
        Death_Sound.Play();
    }
}
