using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FoodManagement : MonoBehaviour
{
    public int satiety;

    public float currentHealth;

    public float rotting;

    public float weight;

    private float _startingHealth;

    private float _endingHealth;

    private float currentRot;

    // Start is called before the first frame update
    void Start()
    {
        _startingHealth = 1;
        _endingHealth = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //currentHealth = _startingHealth - rotting;
        currentHealth = Mathf.Lerp(_endingHealth, _startingHealth, currentRot);
        print(currentHealth);
    }


}
