using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepSound : MonoBehaviour
{
    public AudioClip[] StepSounds;
    public AudioClip Death;
    public AudioClip[] Jump;
    public AudioClip Slide;
    private AudioSource _audioSource;
    // Start is called before the first frame update
    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public void Step_sound_play()
    {
        _audioSource.PlayOneShot(StepSounds[Random.Range(0, StepSounds.Length)]);
    }
    public void Death_sound_play()
    {
        _audioSource.PlayOneShot(Death);
    }
    public void slide_play_sound()
    {
        _audioSource.PlayOneShot(Slide);
    }
    public void Jump_sound_play()
    {
        _audioSource.PlayOneShot(Jump[Random.Range(0, Jump.Length)]);
    }
}
