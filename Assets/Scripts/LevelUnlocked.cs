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
    }

}
