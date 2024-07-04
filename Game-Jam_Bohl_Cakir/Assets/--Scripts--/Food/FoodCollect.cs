using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodCollect : MonoBehaviour
{
    private FoodManagement _foodManagement;

    private Food _food;
    
    // Start is called before the first frame update
    void Start()
    {
        _foodManagement = GameObject.Find("GameManager").GetComponent<FoodManagement>();
    }


    // Destroy instantiated items and add their stats
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Food"))
        {
            _food = other.GetComponent<Food>();
            _food.AddStats();
            Destroy(other.gameObject);
        }

        
    }
}
