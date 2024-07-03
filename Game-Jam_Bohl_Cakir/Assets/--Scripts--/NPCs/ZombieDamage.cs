using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieDamage : MonoBehaviour
{
    public float zombieRot;
    
    private FoodManagement _foodManagement;

    private float _currentRot;


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
        if (other.CompareTag("Player"))
        {
            _currentRot = _foodManagement.rotting;
            StartCoroutine(ApplyZombieRot());
            
        }
    }

    IEnumerator ApplyZombieRot()
    {
        _foodManagement.rotting = zombieRot;
        yield return new WaitForSeconds(5);
        _foodManagement.rotting = _currentRot;
        gameObject.SetActive(false);
    }
}
