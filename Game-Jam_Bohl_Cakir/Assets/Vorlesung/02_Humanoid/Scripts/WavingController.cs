using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WavingController : MonoBehaviour
{

    private Animator _animator;

    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            _animator.SetTrigger("isWaving");
        }

        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            bool isDancing = _animator.GetBool("isDancing");

            _animator.SetBool("isDancing", !isDancing);
        }

 
    }
}
