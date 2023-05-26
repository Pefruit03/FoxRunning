using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuFunction : MonoBehaviour
{
    public AudioSource buttonPress;
    private int bestScore;
    public GameObject bestScoreDisplay;

    // Start is called before the first frame update
    void Start()
    {
        bestScore = PlayerPrefs.GetInt("LevelScore");
        bestScoreDisplay.GetComponent<Text>().text = "Highest score: " + bestScore;
    }

    public void PlayGame()
    {
        buttonPress.Play();
        GlobalScore.currentScore = 0;
        RedirectToLevel.redirectToLevel = 3;
        SceneManager.LoadScene(2);
    }

    public void QuitGame()
    {
        buttonPress.Play();
        Application.Quit();
    }
    
    public void ResetBest()
    {
        buttonPress.Play();
        PlayerPrefs.SetInt("LevelScore", 0);
        PlayerPrefs.SetInt("LevelScore5", 0);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        bestScoreDisplay.GetComponent<Text>().text = "Highest score: " + bestScore;
    }
}
