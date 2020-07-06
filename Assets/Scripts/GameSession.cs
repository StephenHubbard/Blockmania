using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameSession : MonoBehaviour
{

    [SerializeField] float countdownText = 10f;
    [SerializeField] TextMeshProUGUI timerText;

    float startTimer;

    // Stars won compared to timer when level is completed
    [Range(0f, 100f)]
    [SerializeField] float threeStar = 10f;
    [Range(0f, 100f)]
    [SerializeField] float twoStar = 6f;
    [Range(0f, 100f)]
    [SerializeField] float oneStar = 3f;

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
        startTimer = countdownText;
    }

    void Update()
    {
        FinishLevel();
    }

    private void FinishLevel()
    {
        if (!levelComplete)
        {
            countdownText -= Time.deltaTime;
            string countdownTextString = countdownText.ToString("F2");
            timerText.text = countdownTextString;


            if (countdownText <= 0)
            {
                Time.timeScale = 0f;
                timerText.text = "0";
            }
        }
        if (levelComplete)
        {
            checkStarsWon();
        }
    }

    private void checkStarsWon()
    {
        LevelController levelController = FindObjectOfType<LevelController>();

        if (countdownText >= startTimer - threeStar)
        {
            levelController.threeStarAnimation();
        }
        else if (countdownText < startTimer - threeStar && countdownText >= startTimer  - twoStar) {
            levelController.twoStarAnimation();
        }
        else
        {
            levelController.oneStarAnimation();
        }
    }
}
