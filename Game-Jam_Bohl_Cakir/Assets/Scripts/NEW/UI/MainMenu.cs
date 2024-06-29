using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public TextMeshProUGUI highscoreLabel;
    public GameObject infoDialogue;
    public bool isInfoOn;

    void Start()
    {
        // Highscore Text/Anzeige
        int highscore = PlayerPrefs.GetInt("highscore", 0);
        highscoreLabel.text = "Highscore: " + highscore;

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
