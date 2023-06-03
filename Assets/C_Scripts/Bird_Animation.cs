using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird_Animation : MonoBehaviour
{
    public Sprite[] sprites;
    public int FramesPerSecond;

    private SpriteRenderer spriterenderer;
    private int IndexSprite;
    private float timer;
    void Start()
    {
        spriterenderer = GetComponent<SpriteRenderer>();
        IndexSprite = 0;
        spriterenderer.sprite = sprites[IndexSprite];
    }
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 1.0f / FramesPerSecond)
        {
            IndexSprite = (IndexSprite + 1) % sprites.Length;
            spriterenderer.sprite = sprites[IndexSprite];
            timer -= 1.0f / FramesPerSecond;
        }
    }
}
