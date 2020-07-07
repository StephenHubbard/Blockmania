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

    // Start is called before the first frame update
    void Start()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        isLevelCompleted();
    }

    private void isLevelCompleted()
    {
        Scene scene = SceneManager.GetActiveScene();
        // print(scene.name);

        foreach (string eachLevel in completedLevels)
        {
            if (eachLevel.Contains(scene.name))
            {
                return;
            }
            else
            {
                completedLevels.Add(scene.name);
            }

        }

        completedLevels.Add(scene.name);

        foreach(string eachLevel in completedLevels)
        {
            print(eachLevel);
        }
    }
}
