using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAudioTrigger : MonoBehaviour
{
    public AudioClip audioClip;

    private AudioSource _audioSource;

    // Start is called before the first frame update
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }


    // Play selfmade audio clip when the zombie starts chasing the player
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _audioSource.PlayOneShot(audioClip, 3f);
        }
    }
}
