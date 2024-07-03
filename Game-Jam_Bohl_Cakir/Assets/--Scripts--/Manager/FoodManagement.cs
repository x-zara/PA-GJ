using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FoodManagement : MonoBehaviour
{
    public static FoodManagement Instance { get; private set; }   

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
        Instance = this;

        _startingHealth = 1f;
        currentHealth = 1f;
        currentHealth = _startingHealth - rotting;
        print(currentHealth);
    }

    // Update is called once per frame
    void Update()
    {
        
        print(currentHealth);
        
        //StartCoroutine(Rot());

        currentHealth -= rotting * Time.deltaTime;
    }

    IEnumerator Rot()
    {
        yield return new WaitForSeconds(3);
        currentHealth -= rotting;

    }
}
