using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    private Text timeText;
    public Text gameOverText;
    public static float timeLeft = 45f;
    public static bool gameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        gameOverText.enabled = false;
        timeText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameOver)
        {
            timeLeft -= Time.deltaTime;
            timeText.text = "Time remaining: " + (int)timeLeft;
            if (timeLeft < 0)
            {
                gameOverText.enabled = true;
                gameOver = true;
            }
        }
    }
}
