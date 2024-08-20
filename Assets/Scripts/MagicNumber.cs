using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MagicNumber : MonoBehaviour
{
    #region Variables

    [SerializeField] private Button _upButton;
    [SerializeField] private Button _downButton;
    [SerializeField] private Button _winButton;
    [SerializeField] private TMP_Text _guessText;
    [SerializeField] private TMP_Text _stepCountText;

    [SerializeField] private int _min;
    [SerializeField] private int _max;

    private int _guess;
    private int _steps;

    #endregion

    #region Unity lifecycle

    private void Start()
    {
        _upButton.onClick.AddListener(StepUp);
        _downButton.onClick.AddListener(StepDown);
        _winButton.onClick.AddListener(BeginGame);

        _upButton.interactable = false;
        _downButton.interactable = false;
        _winButton.GetComponentInChildren<TMP_Text>().text = "ok";

        _guessText.text = $"guess the number from {_min} to {_max}\n";
    }

    #endregion

    #region Private methods

    private void BeginGame()
    {
        _upButton.interactable = true;
        _downButton.interactable = true;
        _winButton.GetComponentInChildren<TMP_Text>().text = "that's my number";
        UpdateText();
        _winButton.onClick.RemoveListener(BeginGame);
        _winButton.onClick.AddListener(Win);
    }

    private void MakeStep()
    {
        _steps++;
        UpdateText();
    }

    private void StepDown()
    {
        _max = _guess;
        MakeStep();
    }

    private void StepUp()
    {
        _min = _guess;
        MakeStep();
    }

    private void UpdateText()
    {
        _guess = (_min + _max) / 2;
        _guessText.text = $"your number is {_guess}?";
        _stepCountText.text = $"steps:\n{_steps}";
    }

    private void Win()
    {
        SceneManager.LoadScene("Win Scene");
    }

    #endregion
}