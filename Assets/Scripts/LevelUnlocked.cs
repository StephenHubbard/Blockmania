using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelUnlocked : MonoBehaviour
{
    [SerializeField] Text starsRequiredText;
    [SerializeField] Text myStarsText;

    int starsRequiredInt;
    int myStarsInt;

    void Start()
    {
        string starsRequiredString = starsRequiredText.GetComponent<Text>().text;
        starsRequiredInt = int.Parse(starsRequiredString);

        string myStarsTextString = myStarsText.GetComponent<Text>().text;
        myStarsInt = int.Parse(myStarsTextString);

        if (starsRequiredInt <= myStarsInt)
        {
            GameObject cancelIcon = transform.GetChild(1).gameObject;
            cancelIcon.SetActive(false);

            GameObject button = transform.GetChild(2).gameObject;
            button.SetActive(true);
        }

        checkLevelStarsDisplay();
    }

    private void checkLevelStarsDisplay()
    {
        PlayerSession playerSession = FindObjectOfType<PlayerSession>();

        if (gameObject.name == "Level 1")
        {
            if (playerSession.level1Stars == 1)
            {
                transform.GetChild(3).gameObject.SetActive(true);
            }
            if (playerSession.level1Stars == 2)
            {
                transform.GetChild(3).gameObject.SetActive(true);
                transform.GetChild(4).gameObject.SetActive(true);
            }
            if (playerSession.level1Stars == 3)
            {
                transform.GetChild(3).gameObject.SetActive(true);
                transform.GetChild(4).gameObject.SetActive(true);
                transform.GetChild(5).gameObject.SetActive(true);
            }
        }

        if (gameObject.name == "Level 2")
        {
            if (playerSession.level2Stars == 1)
            {
                transform.GetChild(3).gameObject.SetActive(true);
            }
            if (playerSession.level2Stars == 2)
            {
                transform.GetChild(3).gameObject.SetActive(true);
                transform.GetChild(4).gameObject.SetActive(true);
            }
            if (playerSession.level2Stars == 3)
            {
                transform.GetChild(3).gameObject.SetActive(true);
                transform.GetChild(4).gameObject.SetActive(true);
                transform.GetChild(5).gameObject.SetActive(true);
            }
        }

        if (gameObject.name == "Level 3")
        {
            if (playerSession.level3Stars == 1)
            {
                transform.GetChild(3).gameObject.SetActive(true);
            }
            if (playerSession.level3Stars == 2)
            {
                transform.GetChild(3).gameObject.SetActive(true);
                transform.GetChild(4).gameObject.SetActive(true);
            }
            if (playerSession.level3Stars == 3)
            {
                transform.GetChild(3).gameObject.SetActive(true);
                transform.GetChild(4).gameObject.SetActive(true);
                transform.GetChild(5).gameObject.SetActive(true);
            }
        }

        if (gameObject.name == "Level 4")
        {
            if (playerSession.level4Stars == 1)
            {
                transform.GetChild(3).gameObject.SetActive(true);
            }
            if (playerSession.level4Stars == 2)
            {
                transform.GetChild(3).gameObject.SetActive(true);
                transform.GetChild(4).gameObject.SetActive(true);
            }
            if (playerSession.level4Stars == 3)
            {
                transform.GetChild(3).gameObject.SetActive(true);
                transform.GetChild(4).gameObject.SetActive(true);
                transform.GetChild(5).gameObject.SetActive(true);
            }
        }

        if (gameObject.name == "Level 5")
        {
            if (playerSession.level5Stars == 1)
            {
                transform.GetChild(3).gameObject.SetActive(true);
            }
            if (playerSession.level5Stars == 2)
            {
                transform.GetChild(3).gameObject.SetActive(true);
                transform.GetChild(4).gameObject.SetActive(true);
            }
            if (playerSession.level5Stars == 3)
            {
                transform.GetChild(3).gameObject.SetActive(true);
                transform.GetChild(4).gameObject.SetActive(true);
                transform.GetChild(5).gameObject.SetActive(true);
            }
        }
    }

}
