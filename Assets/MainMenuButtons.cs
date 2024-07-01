using UnityEngine;
using UnityEngine.UIElements;

public class MainMenuButtons : MonoBehaviour
{
    public GameObject scrollView;
    private GameObject playButton;
    private GameObject settingsButton;
    private GameObject backFromSettingsButton;
    public void OnPlayButtonClick()
    {
        scrollView.SetActive(true);
        playButton.SetActive(false);
        settingsButton.SetActive(false);
    }

    public void OnSettingsButtonClick()
    {
        playButton.SetActive(false);
        settingsButton.SetActive(false);
        backFromSettingsButton.SetActive(true);
    }

    public void OnBackFromSettingsButtonClick() {
        playButton.SetActive(true);
        settingsButton.SetActive(true);
        backFromSettingsButton.SetActive(false);
    }

    public void Start() {
        playButton = GameObject.Find("Play Button");
        settingsButton = GameObject.Find("Settings Button");
        backFromSettingsButton = GameObject.Find("Back From Settings Button");
        backFromSettingsButton.SetActive(false);
    }
}
