using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

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
    public bool levelLose = false;
    private bool oneTime = true;



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
                timerText.text = "0";
                playerLose();
                levelLose = true;
            }
        }
        if (levelComplete && oneTime)
        {
            checkStarsWon();
        }
    }

    private void playerLose()
    {
        LevelController levelController = FindObjectOfType<LevelController>();
        levelController.playerLoseMenu();
    }

    private void checkStarsWon()
    {
        PlayerSession playerSession = FindObjectOfType<PlayerSession>();
        LevelController levelController = FindObjectOfType<LevelController>();

        if ((countdownText >= startTimer - threeStar) && oneTime == true)
        {
            levelController.threeStarAnimation();
            oneTime = false;
            playerSession.evalLevel(3);
            
        }
        else if (countdownText < startTimer - threeStar && countdownText >= startTimer  - twoStar) {
            levelController.twoStarAnimation();
            oneTime = false;
            playerSession.evalLevel(2);
        }
        else
        {
            levelController.oneStarAnimation();
            oneTime = false;
            playerSession.evalLevel(1);
        }
    }
}
