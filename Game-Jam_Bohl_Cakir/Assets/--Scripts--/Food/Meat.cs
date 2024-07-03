using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meat : Food
{
    public Food meat = new Food() { satiety = 10, rotting = 10, weight = 10 }; 
    
    private FoodManagement _foodManagement;

    // Start is called before the first frame update
    void Start()
    {
        _foodManagement = GameObject.Find("GameManager").GetComponent<FoodManagement>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddMeat()
    {
        _foodManagement.satiety += satiety;
        _foodManagement.weight += weight;
        if (_foodManagement.rotting < rotting)
        {
            _foodManagement.rotting = rotting;
        }
    }
}
