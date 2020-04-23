using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishLineScript : MonoBehaviour
{
    public Text lapText;
    int lapCounter = 1;

    private void OnTriggerEnter(Collider other)
    {
        lapCounter++;
        lapText.text = "Lap: " + lapCounter;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
