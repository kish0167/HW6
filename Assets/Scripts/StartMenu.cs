using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour
{
    #region Variables

    [SerializeField] private Button _startButton;
    [SerializeField] private Button _exitButton;

    #endregion

    #region Unity lifecycle

    private void Start()
    {
        _startButton.onClick.AddListener(StartGame);
        _exitButton.onClick.AddListener(ExitGame);
    }

    #endregion

    #region Private methods

    private void ExitGame()
    {
        Application.Quit();
    }

    private void StartGame()
    {
        SceneManager.LoadScene("Game Scene");
    }

    #endregion
}