using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieDamage : MonoBehaviour
{
    public float zombieRot;
    
    private FoodManagement _foodManagement;

    private float _currentRot;

    private bool _hasHit;

    // Start is called before the first frame update
    void Start()
    {
        _foodManagement = GameObject.Find("GameManager").GetComponent<FoodManagement>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && _hasHit == false)
        {
            _foodManagement.currentHealth -= zombieRot;
            _hasHit = true;
            StartCoroutine(ApplyZombieRot());
        }
    }

    IEnumerator ApplyZombieRot()
    {
        //_currentRot = _foodManagement.rotting;
        //if(_foodManagement.rotting != zombieRot)
        //{
            //_foodManagement.rotting = zombieRot;
            //yield return new WaitForSeconds(2f);
        //}
        yield return new WaitForSeconds(2f);
        //_foodManagement.rotting = _currentRot;
        gameObject.SetActive(false);
    }
}
