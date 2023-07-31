using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance { get; private set; }

    public Sound[] sound;

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }


        foreach (var s in sound)
        {
            s.audioSource = gameObject.AddComponent<AudioSource>();
            s.audioSource.clip = s.audioClip;
            s.audioSource.volume = s.volume;
            s.audioSource.pitch = s.pitch;
            s.audioSource.loop = s.looping;
        }
    }

    private void Start()
    {
        play("Music");
    }

    public void play(string Name)
    {
        Sound s = Array.Find(sound, sound => sound.name == Name);
        if (s == null)
        {
            return;
        }
        s.audioSource.Play();
    }
}
