using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroScreen : MonoBehaviour
{
    private Animator _animator;
    
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
        StartCoroutine(WaitTilDissolve());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator WaitTilDissolve()
    {
        yield return new WaitForSeconds(5);
        _animator.SetBool("FadeIn", true);
    }
}
