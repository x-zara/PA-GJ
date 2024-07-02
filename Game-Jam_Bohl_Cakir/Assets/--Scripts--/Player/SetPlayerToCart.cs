using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPlayerToCart : MonoBehaviour
{
    private Transform _cartTransform;

    private DisplayText _displayText;

    private PlayerController _playerController;

    private GameObject _cart;

    private bool hasGrabbed = false;
    
    // Start is called before the first frame update
    void Start()
    {
        _cartTransform = GameObject.Find("Player_Anchor").transform;
        _displayText = GameObject.Find("Cart_Trigger").GetComponent<DisplayText>();
        _playerController = GetComponent<PlayerController>();
        _cart = GameObject.Find("Cart");
    }

    // Update is called once per frame
    void Update()
    {
        if(_displayText.isClose && Input.GetKeyDown(KeyCode.E))
        {
            SetToCart();
        }
    }

    private void SetToCart()
    {
        //Set the player's position and rotation to the player anchor's position and set the cart as a child object of the player
        _playerController.gameObject.SetActive(false);
        gameObject.transform.position = new Vector3 (_cartTransform.position.x, gameObject.transform.position.y, _cartTransform.position.z);
        gameObject.transform.rotation = _cartTransform.rotation;
        _playerController.gameObject.SetActive(true);
        // https://docs.unity3d.com/ScriptReference/Transform.SetParent.html
        _cart.transform.SetParent(gameObject.transform, true);

        hasGrabbed = true;
    }
}
