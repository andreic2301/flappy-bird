using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Reset_game : MonoBehaviour
{
    public GameObject playButton;
    public void Reset_Game()
    {
        gameObject.SetActive(false);
        Bird bird= FindAnyObjectByType<Bird>();
        bird.transform.position = new Vector3(0, 0);
        playButton.SetActive(true);
        Pipe[] arr= FindObjectsOfType<Pipe>();
        for (int i = 0; i < arr.Length; ++i)
            Destroy(arr[i].gameObject);
        TMP_Text scoreText;
        scoreText = GameObject.Find("NumberOfScore").GetComponent<TMP_Text>();
        scoreText.text = "";
    }
}
