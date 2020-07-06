using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLevel : MonoBehaviour
{

    Color winColor;
    [SerializeField] GameObject winColorMatchBlock;
    [SerializeField] GameObject playerAnimatorGameObject;


    private void Start()
    {
        winColor = winColorMatchBlock.GetComponent<SpriteRenderer>().color;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        Color playerColor = collision.gameObject.GetComponent<SpriteRenderer>().color;

        if (playerColor == winColor)
        {
            GameSession gameSession = FindObjectOfType<GameSession>();
            gameSession.levelComplete = true;
        }
        else if (collision.tag == "Player")
        {
            var playerSprite = playerAnimatorGameObject.GetComponent<Animator>();
            playerSprite.SetTrigger("wrongColor");
        }
    }
}
