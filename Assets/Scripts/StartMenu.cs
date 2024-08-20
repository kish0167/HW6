using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour
{
    [SerializeField] private Button _startButton;
    [SerializeField] private Button _exitButton;
    
    void Start()
    {
        _startButton.onClick.AddListener(StartGame);
        _exitButton.onClick.AddListener(ExitGame);
    }

    private void ExitGame()
    {
        Application.Quit();
    }

    private void StartGame()
    {
        SceneManager.LoadScene("Game Scene");
    }
    
    
}
