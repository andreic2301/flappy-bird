using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving_Background : MonoBehaviour
{
    SpriteRenderer sprite_renderer;
    public float speed = 2;
    void Start()
    {
        sprite_renderer = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        sprite_renderer.material.mainTextureOffset += new Vector2(Time.deltaTime/speed, 0);
    }
}
