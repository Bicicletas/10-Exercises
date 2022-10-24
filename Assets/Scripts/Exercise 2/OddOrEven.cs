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
        // Every time you hit the Space key it determinates if the number entered on the inspector using the int variable
        // if its odd or even by dividing it by 2 and if the operation is exact is even else is odd
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
