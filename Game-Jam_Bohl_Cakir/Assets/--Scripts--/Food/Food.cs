using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    
    
    public int satiety;

    public float rotting;

    public float weight;

    private int _colliderDamage = 25;

    private void Start()
    {
        
    }

    public void AddStats()
    {
        FoodManagement.Instance.satiety += satiety;
        FoodManagement.Instance.weight += weight;
        if (FoodManagement.Instance.rotting < rotting)
        {
            FoodManagement.Instance.rotting = rotting;
        }
    }

    public void RemoveStats()
    {
        print("Hello");
        FoodManagement.Instance.satiety -= _colliderDamage;

        FoodManagement.Instance.weight -= weight;
        if (FoodManagement.Instance.rotting < rotting)
        {
            FoodManagement.Instance.rotting = rotting;
        }
    }

}
