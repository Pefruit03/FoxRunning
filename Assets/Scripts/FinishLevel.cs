using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FinishLevel : MonoBehaviour
{
    public GameObject levelMusic;
    public AudioSource levelComplete;
    public GameObject levelTimer;
    public GameObject timeLeft;
    public GameObject theScore;
    public GameObject totalScore;
    public int timeCalc;
    public int scoreCalc;
    public int totalScored;
    public GameObject fadeOut;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject.Find("Player").SetActive(false);
        timeCalc = GlobalTimer.extendScore * 10;
        timeLeft.GetComponent<Text>().text = "Time left: " + GlobalTimer.extendScore + " x 10";
        theScore.GetComponent<Text>().text = "Score: " + GlobalScore.currentScore;
        totalScored = GlobalScore.currentScore + timeCalc;
        totalScore.GetComponent<Text>().text = "Total Score: " + totalScored;
        PlayerPrefs.SetInt("LevelScore", totalScored);
        levelMusic.SetActive(false);
        levelTimer.SetActive(false);
        levelComplete.Play();
        StartCoroutine(CalculatorScore());
    }

    IEnumerator CalculatorScore()
    {
        timeLeft.SetActive(true);
        yield return new WaitForSeconds(1);
        theScore.SetActive(true);
        yield return new WaitForSeconds(1);
        totalScore.SetActive(true);
        yield return new WaitForSeconds(2);
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(2);
        GlobalScore.currentScore = totalScored;
        Coin.numberOfCoins = 0;
        SceneManager.LoadScene(RedirectToLevel.nextLevel);
    }
}
