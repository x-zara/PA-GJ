using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawning : MonoBehaviour
{

    private GameObject astronaut;
    private Renderer astronautRenderer;
    private Material material;

    // Start is called before the first frame update
    void Start()
    {
        astronaut = GameObject.Find("Astronaut");
        astronautRenderer = astronaut.GetComponentInChildren<Renderer>();
        material = astronautRenderer.GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        if (astronaut.transform.position.y <= 0f)
        {
            print("gefallen");
            ResetPlayer();
        }
    }

    public void ResetPlayer()
    {
        astronaut.transform.position = new Vector3(0.13f, 1.05f, -2.12f);
        astronautRenderer.material.color = Random.ColorHSV();
    }
}
