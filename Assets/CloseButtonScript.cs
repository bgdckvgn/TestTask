using UnityEngine;

public class CloseButtonScript : MonoBehaviour
{
    public GameObject playButton;
    public GameObject settingsButton;
    public GameObject scrollView;
    public void CloseScrollViewAndBack() {
        playButton.SetActive(true);
        settingsButton.SetActive(true);
        scrollView.SetActive(false);
    }
}
