using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OddOrEven : MonoBehaviour
{
    public int number;

    public TextMeshProUGUI textNumber;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(number%2 == 0)
            {
                textNumber.text = $"{number} is even";
            }
            else
            {
                textNumber.text = $"{number} is odd";
            }
        }
    }
}
