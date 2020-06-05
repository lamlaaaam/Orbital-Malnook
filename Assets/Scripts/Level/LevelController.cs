﻿using UnityEngine;
using UnityEngine.UI;

public class LevelController : MonoBehaviour
{
    public Text text;
    public ParticleSystem explosion;
    public void SetLevel(int level)
    {
        text.text = level.ToString();
    }

    public void LevelExplode()
    {
        explosion.Play();
    }
}