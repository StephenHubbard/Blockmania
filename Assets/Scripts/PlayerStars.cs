using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStars : MonoBehaviour
{

    void Start()
    {
        PlayerSession playerSession = FindObjectOfType<PlayerSession>();
        string playerStarsStr =  playerSession.playerStars.ToString();
        GetComponent<Text>().text = playerStarsStr;
    }

    private void Update()
    {
        
    }

}
