using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public static int numberOfCoins = 0;
    public GameObject scoreBox;
    public AudioSource collectSound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            GlobalScore.currentScore += 50;
            numberOfCoins++;
            collectSound.Play();
            Destroy(gameObject);
        }
    }
}
