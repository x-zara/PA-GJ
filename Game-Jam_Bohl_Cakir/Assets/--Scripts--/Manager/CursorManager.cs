using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class CursorManager : MonoBehaviour
{
    private GameManager _gameManager;

    private void Start()
    {
        _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Cursor locked when playing, not locked when in menus
    private void Update()
    {
         if (_gameManager.isPaused)
         {
            Cursor.lockState = CursorLockMode.None;
         }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
   
}
