using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemThrower : MonoBehaviour
{
    public GameObject[] foodItems;

    public int _forceStrength;

    private GameObject _spawner;

    private Vector3 _spawnPosition;

    private Rigidbody _rb;

    private FoodSpawn _foodSpawn;

    private Food _food;


    // Start is called before the first frame update
    void Start()
    {
        _spawner = GameObject.Find("Spawner");

        _foodSpawn = GameObject.Find("Trigger_Bakery").GetComponent<FoodSpawn>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Throws an item out of the cart
    public void ThrowItem()
    {
        float _zPosition = (_spawner.transform.position.z + UnityEngine.Random.Range(-_foodSpawn._zRange, _foodSpawn._zRange));
        float _xPosition = (_spawner.transform.position.x + UnityEngine.Random.Range(-_foodSpawn._xRange, _foodSpawn._xRange));

        _spawnPosition = _spawner.gameObject.transform.position;
        int index = UnityEngine.Random.Range(0, foodItems.Length);
        GameObject newItem = GameObject.Instantiate(foodItems[index], _spawnPosition, Quaternion.identity);
        _rb = newItem.GetComponent<Rigidbody>();
        Vector3 _offset = new Vector3(UnityEngine.Random.Range(0, 1), 0, 0);
        _rb.AddForce((Vector3.up + _offset )* _forceStrength, ForceMode.Impulse);
        _food = _rb.gameObject.GetComponent<Food>();
        _food.RemoveStats();
        StartCoroutine(WaitTilRemove());
        
    }

    IEnumerator WaitTilRemove()
    {
        yield return new WaitForSeconds(2);
        Destroy(_rb.gameObject);

    }
}
