using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleAmbientSound : MonoBehaviour
{
    public AudioSource ambientAudioSource;
    public Button toggleButton;

    void Start()
    {
        // Make sure the AudioSource and Button are assigned
        if (ambientAudioSource == null || toggleButton == null)
        {
            Debug.LogError("Please assign the AudioSource and Button in the inspector.");
            return;
        }

        // Set up the button click event
        toggleButton.onClick.AddListener(ToggleAmbientSoundState);
    }

    void ToggleAmbientSoundState()
    {
        if (ambientAudioSource.isPlaying)
        {
            // If the audio is currently playing, stop it
            ambientAudioSource.Stop();
        }
        else
        {
            // If the audio is not playing, start playing it
            ambientAudioSource.Play();
        }
    }
}
