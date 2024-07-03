using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip _newClip;
    private AudioSource _backgroundMusic;

    // Start is called before the first frame update
    void Start()
    {
        _backgroundMusic = GameObject.Find("Main Camera").GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _backgroundMusic.clip = _newClip;
            _backgroundMusic.Play();
        }
    }
}
