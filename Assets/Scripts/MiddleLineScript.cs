using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddleLineScript : MonoBehaviour
{
    public static bool passedMiddleLine = false;

    private void OnTriggerEnter(Collider other) {
        passedMiddleLine = true;
    }
}
