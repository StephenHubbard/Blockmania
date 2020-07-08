using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerSession : MonoBehaviour
{

    public List<string> completedLevels = new List<string>();

    public int playerStars = 0;

    private void Awake()
    {
        // Singleton pattern
        int numPlayerSessions = FindObjectsOfType<PlayerSession>().Length;
        if (numPlayerSessions > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    void Start()
    {
        // SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void Update()
    {

    }

    // void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    // {
    //  isLevelCompleted();
    // }

    public void isLevelCompleted()
    {
        Scene scene = SceneManager.GetActiveScene();

        foreach (string eachLevel in completedLevels)
        {
            if (eachLevel.Contains(scene.name))
            {
                print("level already completed");
                return;
            }
        }

        completedLevels.Add(scene.name);
    }
}
