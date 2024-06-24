using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    // how many items the player should collect
    public int itemValueToCollect = 5;

    // Textfield showing the number of collected items
    public TextMeshProUGUI collectedItemsLabel;

    // how many values the player already has collected
    public int CollectedItemsValue {  get; private set; }
    
    // Start is called before the first frame update
    void Start()
    {
        CollectedItemsValue = 0;
        UpdateHUD();
    }

    // Update is called once per frame
    public void ItemCollected(int itemValue)
    {
        CollectedItemsValue += itemValue;
        UpdateHUD();
    }

    private void UpdateHUD()
    {
        if (CollectedItemsValue == itemValueToCollect)
        {
            collectedItemsLabel.text = "Success!";
        }

        else
        {
            collectedItemsLabel.text = CollectedItemsValue + "/" + itemValueToCollect;
        }
    }
}
