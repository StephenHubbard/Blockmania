using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelController : MonoBehaviour
{
    [SerializeField] GameObject winLabel;
    [SerializeField] GameObject loseLabel;

    int currentSceneIndex;

    void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
    }


    public void LoadMainMenu()
    {
        SceneManager.LoadScene("Start Screen");
    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void oneStarAnimation()
    {
        if (!winLabel.GetComponent<Animator>().GetBool("oneStar"))
        {
            winLabel.GetComponent<Animator>().SetBool("oneStar", true);
        }
    }

    public void twoStarAnimation()
    {
        if (!winLabel.GetComponent<Animator>().GetBool("twoStar"))
        {
            winLabel.GetComponent<Animator>().SetBool("twoStar", true);
        }
    }

    public void threeStarAnimation()
    {
        if (!winLabel.GetComponent<Animator>().GetBool("threeStar"))
        {
            winLabel.GetComponent<Animator>().SetBool("threeStar", true);
        }
    }
}
