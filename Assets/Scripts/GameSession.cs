using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameSession : MonoBehaviour
{

    [SerializeField] float countdownText = 10f;
    [SerializeField] TextMeshProUGUI timerText;

    public bool levelComplete = false;

    private void Awake()
    {
        // Singleton pattern
        /* int numGameSessions = FindObjectsOfType<GameSession>().Length;
        if (numGameSessions > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        } */
    }

    private void Start()
    {
        timerText.text = countdownText.ToString();
    }

    void Update()
    {
        if (!levelComplete)
        {
            countdownText -= Time.deltaTime;
            string countdownTextString = countdownText.ToString("F2");
            timerText.text = countdownTextString;

            if (countdownText <= 0 )
            {
                Time.timeScale = 0f;
                timerText.text = "0";
            }
        }
    }

}
