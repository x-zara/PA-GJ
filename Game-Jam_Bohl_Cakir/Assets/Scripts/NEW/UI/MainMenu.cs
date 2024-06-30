using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject infoDialogue;
    public bool isInfoOn;

    void Start()
    {
       
    }

    public void Info(bool doInfo)
    {
        // Infodialog
        isInfoOn = doInfo;
        infoDialogue.SetActive(isInfoOn);

    }

    // Applikation beenden
    public void QuitGame()
    {

        Application.Quit();

    }

    // Spiel starten -> Wechsel zur GameView Szene
    public void StartGame()
    {

        SceneManager.LoadScene(1);

    }
}
