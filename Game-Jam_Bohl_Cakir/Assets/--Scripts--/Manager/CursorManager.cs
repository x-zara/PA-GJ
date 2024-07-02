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

    public void OnApplicationFocus(bool focus)
    {
        if(focus)
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }

    private void Update()
    {
         if (_gameManager.isPaused == false || _gameManager.isGameOver)
         {
            Cursor.lockState = CursorLockMode.Locked;
         }
        else
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }
   
}
