using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

[RequireComponent(typeof(AudioSource))]
public class PlayerInteraction : MonoBehaviour
{
    [SerializeField] private UnityEvent noteInteraction;

    private AudioSource myAudioSource;

    private void Start()
    {
        myAudioSource = GetComponent<AudioSource>();
        myAudioSource.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            myAudioSource.enabled = true;
            noteInteraction.Invoke();
        }

    }
    
}
