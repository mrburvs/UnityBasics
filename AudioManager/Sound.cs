using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]
public class Sound
{
    public string name;

    public AudioClip clip;

    [Range(0f, 2f)]
    public float volume;
    public float pitch = 1f;

    public bool loop;

    [HideInInspector]
    public AudioSource source;
}
