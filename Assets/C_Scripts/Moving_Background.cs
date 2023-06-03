using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving_Background : MonoBehaviour
{
    SpriteRenderer sprite_renderer;
    void Start()
    {
        sprite_renderer = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        sprite_renderer.material.mainTextureOffset += new Vector2(Time.deltaTime, 0);
    }
}
