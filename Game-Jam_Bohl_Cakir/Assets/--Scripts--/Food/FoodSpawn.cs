using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FoodSpawn : MonoBehaviour
{
    public GameObject[] foodItems;
    
    private float _zRange;

    private float _xRange;

    private Renderer _renderer;

    private Vector3 _spawnPosition;

    private GameObject _spawner;

    private DisplayText _displayText;
    
    // Start is called before the first frame update
    void Start()
    {
        _displayText = GetComponent<DisplayText>();

        _spawner = GameObject.Find("Spawner");
        
        _renderer = _spawner.GetComponent<Renderer>();

        // https://discussions.unity.com/t/find-size-of-gameobject/6193
        _zRange = _renderer.bounds.size.z / 2;

        _xRange = _renderer.bounds.size.x / 2; 

        
    }

    // Update is called once per frame
    void Update()
    {
        if (_displayText.isClose && Input.GetKeyDown(KeyCode.E))
        {
            SpawnFood(0);
        }
    }

    // Spawns a food item from the selected shop using the size of the spawner as range
    public void SpawnFood(int index)
    {
        float _zPosition = (_spawner.transform.position.z + Random.Range(-_zRange, _zRange));
        float _xPosition = (_spawner.transform.position.x + Random.Range(-_xRange, _xRange));
        
        _spawnPosition = new Vector3(_xPosition, _spawner.gameObject.transform.position.y, _zPosition);
        index = Random.Range(0, foodItems.Length);
        GameObject.Instantiate(foodItems[index], _spawnPosition, Quaternion.identity );
    }
}
