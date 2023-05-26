using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    private int score;
    public GameObject scoreDisplay;
    public AudioSource clickSound;

    void Start()
    {
        score = PlayerPrefs.GetInt("LevelScore");
        scoreDisplay.GetComponent<Text>().text = "Score: " + score;
    }
    public void LoadMenuScence()
    {
        clickSound.Play();
        SceneManager.LoadScene(1);
    }
    public void Quit()
    {
        clickSound.Play();
        Application.Quit();
    }

}
