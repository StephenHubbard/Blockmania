using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelLoader : MonoBehaviour
{
    [SerializeField] int timeToWait = 3;

    int currentSceneIndex;

    public void RestartScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(currentSceneIndex);
    }

    public void LoadMainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Start Screen");
    }

    public void LoadOptionsScreen()
    {
        SceneManager.LoadScene("Options Screen");
    }

    public void LoadLevelSelectorScreen()
    {
        SceneManager.LoadScene("Choose Level");
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void LoadYouLose()
    {
        SceneManager.LoadScene("Lose Screen");
    }

    public void LoadLevel1()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void LoadWorldSelection()
    {
        SceneManager.LoadScene("World Selection");
    }

    public void LoadWorld1Selection()
    {
        SceneManager.LoadScene("World 1 Level Selection");
    }

    public void LoadLevel()
    {
        GameObject buttonSelected = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject;
        string levelIndexString = buttonSelected.GetComponent<Text>().text;
        SceneManager.LoadScene(levelIndexString);
    }
}
