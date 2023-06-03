using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Counting_Score : MonoBehaviour
{
    TMP_Text scoreText;

    public static int cnt;
    private void Start()
    {
        scoreText = GameObject.Find("NumberOfScore").GetComponent<TMP_Text>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Bird")
        {
            cnt++;
            scoreText.text = cnt.ToString();
        }
    }
}
