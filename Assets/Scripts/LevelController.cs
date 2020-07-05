using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelController : MonoBehaviour
{
    [SerializeField] GameObject winLabel;
    [SerializeField] GameObject loseLabel;

    public void ScrollBannerTrigger()
    {
        winLabel.GetComponent<Animator>().SetTrigger("playerWins");
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("Start Screen");
    }
}
