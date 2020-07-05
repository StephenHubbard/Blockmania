using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLevel : MonoBehaviour
{

    Color winColor;
    float greenRValue = 0.08904416f;

    private void Start()
    {
        winColor = GetComponent<SpriteRenderer>().color;
        winColor.r = greenRValue;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        Color playerColor = collision.gameObject.GetComponent<SpriteRenderer>().color;

        if (playerColor.r >= winColor.r - Mathf.Epsilon && playerColor.r <= winColor.r + Mathf.Epsilon)
        {
            print("you win!");
            LevelController levelController = FindObjectOfType<LevelController>();
            levelController.ScrollBannerTrigger();
            GameSession gameSession = FindObjectOfType<GameSession>();
            gameSession.levelComplete = true;
        }
        else
        {
            print("wrong color");
        }
    }
}
