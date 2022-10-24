using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GenerateNumber : MonoBehaviour
{
    public TextMeshProUGUI number;

    public int lowNum = 0;

    public int highNum = 10000;

    // Function created for a button that changes the text value of UI text to a
    // random number between a range of 2 numbers determinated in the inspector
    public void Generate()
    {
        number.text = $"{Random.Range(lowNum, highNum)}";
    }
}
