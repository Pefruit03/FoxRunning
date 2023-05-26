using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Falling : MonoBehaviour
{
    public GameObject levelTimer;
    public GameObject timeLeft;
    public GameObject theScore;
    public GameObject totalScore;
    public GameObject fadeOut;
    public int timeCalc;
    public int scoreCalc;
    public int totalScored;

    private void Reset()
    {
        GetComponent<BoxCollider2D>().isTrigger = true;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        LifeCount.heart = 0;
        GameObject.Find("Player").SetActive(false);
        timeLeft.GetComponent<Text>().text = "Time left: " + " 0";
        theScore.GetComponent<Text>().text = "Score: " + GlobalScore.currentScore;
        totalScored = GlobalScore.currentScore;
        totalScore.GetComponent<Text>().text = "Total Score: " + totalScored;
        PlayerPrefs.SetInt("LevelScore", totalScored);
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
        GlobalScore.currentScore = 0;
        SceneManager.LoadScene(7);
    }
}
