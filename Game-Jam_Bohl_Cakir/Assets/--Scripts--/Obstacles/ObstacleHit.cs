using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleHit : MonoBehaviour
{
    public AudioClip audioClip;

    private ItemThrower _itemThrower;

    private AudioSource _audioSource;
    
    // Start is called before the first frame update
    void Start()
    {
        _itemThrower = GameObject.Find("GameManager").GetComponent<ItemThrower>();

        _audioSource = GameObject.Find("Player").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        _audioSource.PlayOneShot(audioClip, 25f);
        
        _itemThrower.ThrowItem();

        Destroy(gameObject);
    }
}
