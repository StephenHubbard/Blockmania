using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GUIButtons : MonoBehaviour
{
    int currentSceneIndex;

    [SerializeField] GameObject retrySymbol;
    [SerializeField] GameObject settingsSymbol;
    [SerializeField] GameObject settingsMenu;

    void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(currentSceneIndex);
    }

    public void SettingsButton()
    {
        Time.timeScale = 0;
        settingsMenu.SetActive(true);
    }

    public void ResumeButton()
    {
        Time.timeScale = 1;
        settingsMenu.SetActive(false);
    }
}
