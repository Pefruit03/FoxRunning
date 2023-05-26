using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            LifeCount.heart--;
            if (LifeCount.heart <= 0)
            {
                GameObject.Find("Player").SetActive(false);
                timeLeft.GetComponent<Text>().text = "Time left: " + " 0";
                theScore.GetComponent<Text>().text = "Score: " + GlobalScore.currentScore;
                totalScored = GlobalScore.currentScore;
                totalScore.GetComponent<Text>().text = "Total Score: " + totalScored;
                PlayerPrefs.SetInt("LevelScore", totalScored);
                StartCoroutine(CalculatorScore());
            }
            else
            {
                StartCoroutine(GetHurt());
            }
        }
    }
    
    IEnumerator GetHurt()
    {
        Physics2D.IgnoreLayerCollision(6, 7);
        GameObject.Find("Player").GetComponent<Animator>().SetLayerWeight(1, 1);
        yield return new WaitForSeconds(0.5f);
        GameObject.Find("Player").GetComponent<Animator>().SetLayerWeight(1, 0);
        Physics2D.IgnoreLayerCollision(6, 7, false);
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
