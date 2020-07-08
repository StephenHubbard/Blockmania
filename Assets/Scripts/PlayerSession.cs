using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerSession : MonoBehaviour
{

    public List<string> completedLevels = new List<string>();

    public int playerStars = 0;

    public int level1Stars = 0;
    public int level2Stars = 0;
    public int level3Stars = 0;
    public int level4Stars = 0;
    public int level5Stars = 0;

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

    // void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    // {
    //  isLevelCompleted();
    // }

    void Update()
    {

    }

    public void evalLevel(int starsWon)
    {
        var currentScene = SceneManager.GetActiveScene().name;

        if (currentScene == "Level1")
        {
            if (level1Stars < starsWon)
            {
                level1Stars = starsWon;
            }
        }

        if (currentScene == "Level2")
        {
            if (level2Stars < starsWon)
            {
                level2Stars = starsWon;
            }
        }

        if (currentScene == "Level3")
        {
            if (level3Stars < starsWon)
            {
                level3Stars = starsWon;
            }
        }

        if (currentScene == "Level4")
        {
            if (level4Stars < starsWon)
            {
                level4Stars = starsWon;
            }
        }

        if (currentScene == "Level5")
        {
            if (level5Stars < starsWon)
            {
                level5Stars = starsWon;
            }
        }

        updatePlayerStarsTotal();
    }

    private void updatePlayerStarsTotal()
    {
        playerStars = level1Stars + level2Stars + level3Stars + level4Stars + level5Stars;
    }

    // not currently using this function.  Found another way to do it for now. 
    public void isLevelCompleted()
    {
        Scene scene = SceneManager.GetActiveScene();

        foreach (string eachLevel in completedLevels)
        {
            if (eachLevel.Contains(scene.name))
            {
                return;
            }
        }

        completedLevels.Add(scene.name);
    }
}
