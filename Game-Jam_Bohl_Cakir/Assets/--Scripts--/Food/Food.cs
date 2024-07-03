using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    public int satiety;

    public float rotting;

    public float weight;

    public FoodManagement _foodManagement;

    private void Start()
    {
        _foodManagement = GameObject.Find("GameManager").GetComponent<FoodManagement>();
    }

    public void AddStats()
    {
        _foodManagement.satiety += satiety;
        _foodManagement.weight += weight;
        if (_foodManagement.rotting < rotting)
        {
            _foodManagement.rotting = rotting;
        }
    }

}
