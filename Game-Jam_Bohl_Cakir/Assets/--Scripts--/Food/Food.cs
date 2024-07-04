using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    
    
    public int satiety;

    public float rotting;

    public float weight;

    private int _colliderDamage = 25;

    // Adds stats to foodmanagement when item gets added to cart
    public void AddStats()
    {
        FoodManagement.Instance.satiety += satiety;
        FoodManagement.Instance.weight += weight;
        if (FoodManagement.Instance.rotting < rotting)
        {
            FoodManagement.Instance.rotting = rotting;
        }
    }

    // Removes satiety when a collider is being hit
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
