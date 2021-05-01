using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using System;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;
    public Sound[] sounds;
      


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
            

        DontDestroyOnLoad(gameObject);

        foreach (Sound s in sounds)
        {
            s.aSource = gameObject.AddComponent<AudioSource>();
            s.aSource.clip = s.clip;
            s.aSource.volume = s.volume;
            s.aSource.pitch = s.pitch;
            s.aSource.loop = s.loop;
        }
    }
    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name );
        s.aSource.Play();
        if (s == null)
        {
            Debug.LogWarning("Sound: "+ name + " not found!");
            return;
        }


    }
    private void Start()
    {
        Play("Theme");
    }

}
