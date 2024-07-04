using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotion : MonoBehaviour
{
    public float healthGain;

    private FoodManagement _foodManagement;

    // Start is called before the first frame update
    void Start()
    {
        _foodManagement = GameObject.Find("GameManager").GetComponent<FoodManagement>();
    }

    // Regains health to the freshness meter
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _foodManagement.currentHealth += healthGain;
            Destroy(gameObject);
        }
        
    }
}
