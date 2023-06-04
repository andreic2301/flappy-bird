using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Start_game : MonoBehaviour
{
    TMP_Text highscoreText;

    private void Start()
    {
        Reset_game.highScore = PlayerPrefs.GetInt("NumberHighscore");
        highscoreText = GameObject.Find("NumberOfHighscore").GetComponent<TMP_Text>();
        highscoreText.text = Reset_game.highScore.ToString();
        GameObject.Find("Background").GetComponent<AudioSource>().Play();
    }
    public void StartGame()
    {
        gameObject.SetActive(false);
        Time.timeScale = 1;
        Moving_Background[] arr = FindObjectsOfType<Moving_Background>();
        for (int i = 0; i < arr.Length; ++i)
            arr[i].enabled = true;
        Bird bird = FindAnyObjectByType<Bird>();
        bird.enabled = true;
        Bird_Animation bird_animation = FindAnyObjectByType<Bird_Animation>();
        bird_animation.enabled = true;
        Pipe_Spawner pipe = FindAnyObjectByType<Pipe_Spawner>();
        pipe.enabled = true;
    }
}
