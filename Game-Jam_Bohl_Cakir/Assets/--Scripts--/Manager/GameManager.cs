using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    //public GameObject gameOverDialogue;
    public GameObject pauseMenuDialogue;

    public bool isPaused = false;
    public bool isGameOver = false;

    private bool isGameStarted = true;
    
    

    //Keine doppelten GameManager beim erneuten Laden von Szenen
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }

        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        //gameOverDialogue.SetActive(false);
        pauseMenuDialogue.SetActive(false);

        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !isGameOver)
        {
            PauseGame(!isPaused);
            Cursor.lockState = CursorLockMode.None;
        }
    }

    public void SetGameOver()
    {
        // Spawnen von Objekten stoppen wenn Game Over
        // FindObjectOfType<PlantSpawnManager>().SetCanSpawn(false);

        //isGameOver = true;
        //gameOverDialogue.SetActive(true);
        //CancelInvoke();

    }

    public void PauseGame(bool doPause)
    {
        isPaused = doPause;
        pauseMenuDialogue.SetActive(isPaused);

        Time.timeScale = isPaused ? 0 : 1;
    }

    public void RestartGame()
    {
        //Szene neu starten
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        // Spawnen wieder starten
        // FindObjectOfType<EnemySpawnManager>().SetCanSpawn(true);
    }

    // Zurück zum Hauptmenü über Pausemenü
    public void BackToMainMenu()
    {
        // MainMenu Szene laden
        SceneManager.LoadScene(0);

        //Spawnen anhalten
        // FindObjectOfType<EnemySpawnManager>().SetCanSpawn(false);
    }

    // Gibt zurück ob Spiel läuft, pausiert oder Game Over ist
    public bool IsGameRunning()
    {
        return !(isGameOver || isPaused);
    }
}
