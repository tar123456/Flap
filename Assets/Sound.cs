using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Sound 
{
    public string name;
    public AudioClip audioClip;
    [Range(0f,1f)]
    public float volume;
    [Range(0.1f,3f)]
    public float pitch;
    
    public bool looping;

    [HideInInspector]
    public AudioSource audioSource;
}
