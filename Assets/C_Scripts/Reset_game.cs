using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Reset_game : MonoBehaviour
{
    static int highScore;
    public GameObject playButton;
    public void Reset_Game()
    {
        gameObject.SetActive(false);
        Bird bird= FindAnyObjectByType<Bird>();
        bird.transform.position = new Vector3(0, 0);
        bird.speed = -1;
        playButton.SetActive(true);
        Pipe[] arr= FindObjectsOfType<Pipe>();
        for (int i = 0; i < arr.Length; ++i)
            Destroy(arr[i].gameObject);

        TMP_Text scoreText;
        scoreText = GameObject.Find("NumberOfScore").GetComponent<TMP_Text>();
        scoreText.text = "";

        TMP_Text highscoreText;
        highscoreText = GameObject.Find("NumberOfHighscore").GetComponent<TMP_Text>();
        highScore = Mathf.Max(highScore, Counting_Score.cnt);
        highscoreText.text = highScore.ToString();

        Counting_Score.cnt = 0;
        bird.rotation = 0;
        bird.transform.rotation = Quaternion.Euler(0, 0, 0);
    }
}
