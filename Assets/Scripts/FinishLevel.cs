using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class FinishLevel : MonoBehaviour
{

    Color winColor;
    string winColorString;
    [SerializeField] GameObject winColorMatchBlock;
    [SerializeField] GameObject playerAnimatorGameObject;


    private void Start()
    {
        winColor = winColorMatchBlock.GetComponent<SpriteRenderer>().color;
        winColorString = ColorUtility.ToHtmlStringRGB(winColor);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        Color playerColor = collision.gameObject.GetComponent<SpriteRenderer>().color;
        string playerColorString = ColorUtility.ToHtmlStringRGB(playerColor);

        if (playerColorString == winColorString)
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
