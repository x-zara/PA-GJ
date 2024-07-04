using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinningCondition : MonoBehaviour
{

    public GameObject[] gameOverDialogue;

    private GameManager _gameManager;

    private Animator _animator;

    private FoodManagement _foodManagement;
    
    // Start is called before the first frame update
    void Start()
    {
        _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        
        _foodManagement = _gameManager.GetComponent<FoodManagement>();

        foreach (GameObject dialogue in gameOverDialogue)
        {
            dialogue.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(_foodManagement.currentHealth <= 0)
        {
            _gameManager.isPaused = true;
            Time.timeScale = 0f;
            gameOverDialogue[3].gameObject.SetActive(true);
            _animator = gameOverDialogue[3].gameObject.GetComponentInChildren<Animator>();
            _animator.SetBool("FadeIn", true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        _gameManager.isPaused = true;
        Time.timeScale = 0f;
        if(_foodManagement.currentHealth<= 0.33f)
        {
            gameOverDialogue[0].gameObject.SetActive(true);
            _animator = gameOverDialogue[0].gameObject.GetComponentInChildren<Animator>();
            Time.timeScale = 1f;
            _animator.SetBool("FadeIn", true);
        }
        
        else if(_foodManagement.satiety <= 100)
        {
            gameOverDialogue[1].gameObject.SetActive(true);
            _animator = gameOverDialogue[1].GetComponentInChildren<Animator>();
            Time.timeScale = 1f;
            _animator.SetBool("FadeIn", true);
        }

        else if(_foodManagement.satiety > 100)
        {
            gameOverDialogue[2].gameObject.SetActive(true);
            _animator = gameOverDialogue[2].gameObject.GetComponentInChildren<Animator>();
            Time.timeScale = 1f;
            _animator.SetBool("FadeIn", true);
        }
    }
}
