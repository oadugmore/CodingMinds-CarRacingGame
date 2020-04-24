using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishLineScript : MonoBehaviour
{
    private int lapCounter = 1;
    public Text lapText;

    private void OnTriggerEnter(Collider other)
    {
        if (!TimerScript.gameOver && MiddleLineScript.passedMiddleLine)
        {
            MiddleLineScript.passedMiddleLine = false;
            lapCounter++;
            lapText.text = "Lap: " + lapCounter;
            TimerScript.timeLeft += 30;
        }
    }
}
