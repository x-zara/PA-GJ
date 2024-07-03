using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayText : MonoBehaviour
{
    public bool isClose;
    
    // The UI label to be turned on and off
    public TextMeshProUGUI _label;
    
    // Start is called before the first frame update
    void Start()
    {
        _label = GetComponentInChildren<TextMeshProUGUI>();

        _label.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _label.gameObject.SetActive(true);

            isClose = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _label.gameObject.SetActive(false);

            isClose = false;
        }
    }
}
