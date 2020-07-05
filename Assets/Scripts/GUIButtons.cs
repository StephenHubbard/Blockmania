using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GUIButtons : MonoBehaviour
{
    int currentSceneIndex;

    [SerializeField] GameObject retrySymbol;
    [SerializeField] GameObject settingsSymbol;

    void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(currentSceneIndex);
    }
}
