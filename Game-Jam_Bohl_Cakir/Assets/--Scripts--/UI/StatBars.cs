using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class StatBars : MonoBehaviour
{
    // Tutorial für das Erstellen einer Healthbar: https://www.youtube.com/watch?v=BLfNP4Sc_iA

    // The healthbar fill
    private Image _fill;

    // The slider controlling the healthbar
    private Slider _slider;

    // Reference to the damage controller script
    private FoodManagement _foodManagement;


    // Start is called before the first frame update
    void Start()
    {
        _fill = GetComponentInChildren<Image>();

        _slider = GetComponentInChildren<Slider>();

        _foodManagement = GameObject.Find("GameManager").GetComponent<FoodManagement>();

    }

    // Update is called once per frame
    void Update()
    {
        // Set the slider using the life points
        _slider.value = _foodManagement.currentHealth;
    }
}
