using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeCount : MonoBehaviour
{
    public Image[] hearts;
    public static int heart = 4;

    public Sprite fullHeart;
    public Sprite emtyHeart;

    private void Awake()
    {
        heart = 4;
    }
    void Update()
    {
        foreach(Image img in hearts)
        {
            img.sprite = emtyHeart;
        }
        for (int i = 0; i < heart; i++)
        {
            hearts[i].sprite = fullHeart;
        }
    }
}
