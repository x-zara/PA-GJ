using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowFood : MonoBehaviour
{

    public GameObject[] Decorations;

    private FoodManagement _foodManagment;
    
    // Start is called before the first frame update
    void Start()
    {
        _foodManagment = GameObject.Find("GameManager").GetComponent<FoodManagement>();

        foreach(var decoration in Decorations)
        {
            decoration.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (_foodManagment.satiety >= 50)
        {

      
            Decorations[0].gameObject.SetActive(true);
            Decorations[1].gameObject.SetActive(true);
            Decorations[2].gameObject.SetActive(false);
            Decorations[3].gameObject.SetActive(false);

        } 
        
        if(_foodManagment.satiety >= 100)
        {
            Decorations[2].gameObject.SetActive(true);
            Decorations[3].gameObject.SetActive(true);
            Decorations[4].gameObject.SetActive(false);
            Decorations[5].gameObject.SetActive(false);
            Decorations[6].gameObject.SetActive(false);
        }
        
        if (_foodManagment.satiety >= 150)
        {
            Decorations[4].gameObject.SetActive(true);
            Decorations[5].gameObject.SetActive(true);
            Decorations[6].gameObject.SetActive(true);
        }
        else
        {

        }

        
    }
}
