﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

[System.Serializable]
public class Sound
{
    public string name;
    public AudioClip clip;
    [Range(0f, 2f)]
    public float volume = 1;
    [Range(.1f, 3f)]
    public float pitch = 1 ;
    [HideInInspector]
    public AudioSource source;

    public bool loop;

}