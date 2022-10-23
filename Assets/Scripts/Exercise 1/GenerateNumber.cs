using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GenerateNumber : MonoBehaviour
{
    public TextMeshProUGUI number;

    private int lowNum = 0;

    private int highNum = 10000;

    public void Generate()
    {
        number.text = $"{Random.Range(lowNum, highNum)}";
    }
}
