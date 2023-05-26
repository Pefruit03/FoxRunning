using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalTimer : MonoBehaviour
{
    public GameObject timeDisplay;
    public bool isTakingTime = false;
    public int theSeconds = 240;
    public static int extendScore;

    // Update is called once per frame
    void Update()
    {
        extendScore = theSeconds;
        if (isTakingTime == false)
        {
            StartCoroutine(SubtractSecond());
        }
    }

    IEnumerator SubtractSecond()
    {
        isTakingTime = true;
        theSeconds -= 1;
        timeDisplay.GetComponent<Text>().text = "" + theSeconds;
        yield return new WaitForSeconds(1);
        isTakingTime = false;
    }
}
