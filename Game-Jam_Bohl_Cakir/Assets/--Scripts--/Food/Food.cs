using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    public int satiety;

    public float rotting;

    public float weight;

    //public FoodManagement _foodManagement;

    private void Start()
    {
        //_foodManagement = GameObject.Find("GameManager").GetComponent<FoodManagement>();
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
        FoodManagement.Instance.satiety -= satiety;

        FoodManagement.Instance.weight -= weight;
        if (FoodManagement.Instance.rotting < rotting)
        {
            FoodManagement.Instance.rotting = rotting;
        }
    }

}
