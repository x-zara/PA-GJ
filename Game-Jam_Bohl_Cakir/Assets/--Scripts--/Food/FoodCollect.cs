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

    // Update is called once per frame
    void Update()
    {
        
    }

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
