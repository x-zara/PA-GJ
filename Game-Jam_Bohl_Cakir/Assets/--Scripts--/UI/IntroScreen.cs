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

    // Wait until the image dissolves by triggering the animation
    IEnumerator WaitTilDissolve()
    {
        yield return new WaitForSeconds(6.5f);
        _animator.SetBool("FadeIn", true);
    }
}
