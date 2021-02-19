using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AssetSounds[] sounds;

    void Awake()
    {
        foreach (AssetSounds s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
        }
    }

    public void Play (string name)
    {
        AssetSounds s = Array.Find(sounds, sound => sound.name == name);
        s.source.Play();
    }

}
