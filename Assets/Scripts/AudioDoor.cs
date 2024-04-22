using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioDoor : MonoBehaviour
{
    [SerializeField] private AudioSource _compAudioSource;
    [SerializeField] private AudioSource audioDoor;
    void Awake()
    {
        _compAudioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Player"))
        {
            _compAudioSource.Play();
        }
        if (collider.CompareTag("Player"))
        {
            audioDoor.Play();
        }
    }
    private void OnTriggerExit(Collider collider)
    {
        if (collider.CompareTag("Player"))
        {
            _compAudioSource.Stop();
        }
        if (collider.CompareTag("Player"))
        {
            audioDoor.Play();
        }
    }

}
