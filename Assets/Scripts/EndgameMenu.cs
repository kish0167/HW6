using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndgameMenu : MonoBehaviour
{
    #region Variables

    [SerializeField] private Button _yesButton;
    [SerializeField] private Button _noButton;

    #endregion

    #region Unity lifecycle

    private void Start()
    {
        _yesButton.onClick.AddListener(StartGame);
        _noButton.onClick.AddListener(ExitGame);
    }

    #endregion

    #region Private methods

    private void ExitGame()
    {
        Application.Quit();
    }

    private void StartGame()
    {
        SceneManager.LoadScene("Start Scene");
    }

    #endregion
}