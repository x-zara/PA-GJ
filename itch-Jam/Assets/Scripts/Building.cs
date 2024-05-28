using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Building : MonoBehaviour
{

    private GameObject astronaut;

    private Respawning respawning;

    public GameObject[] pathParts;

    public TMP_Text interactionText;



    
    // Start is called before the first frame update
    void Start()
    {
        astronaut = GameObject.Find("Astronaut");

        interactionText.enabled = false;

        foreach (GameObject part in pathParts)
        {
            part.SetActive(false);
        }

        respawning = GameObject.Find("GameManager").GetComponent<Respawning>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Astronaut"))
        {
            interactionText.enabled = true;

            if (Input.GetKeyDown(KeyCode.E))
            {
                foreach (GameObject part in pathParts)
                {
                    part.SetActive(true);
                }

                respawning.ResetPlayer();
            }
        }
    }

    void Build()
    {
        foreach(GameObject part in pathParts)
        {
            part.SetActive(true);
        }
    }


}
