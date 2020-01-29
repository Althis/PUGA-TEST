using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

public class timer : MonoBehaviour
{
    public int remainingTime;
    public Text timeDisplay;

    void Start()
    {
        StartCoroutine("countDown");
    }

    void Update()
    {
        // timeDisplay.text = "" + ((int)remainingTime/60) + ":" + ((int) remainingTime % 60);
        timeDisplay.text = ""+remainingTime;
    }

    IEnumerator countDown(){
        while(true) {
            yield return new WaitForSeconds(1);
            remainingTime--;
        }
    }
}
