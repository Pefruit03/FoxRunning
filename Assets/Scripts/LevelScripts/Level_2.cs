using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_2 : MonoBehaviour
{
    public GameObject fadeIn;
    void Start()
    {
        RedirectToLevel.redirectToLevel = 4;
        RedirectToLevel.nextLevel = 5;
        StartCoroutine(FadeInOff());
    }

    IEnumerator FadeInOff()
    {
        yield return new WaitForSeconds(1);
        fadeIn.SetActive(false);
    }
}
