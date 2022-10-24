using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InputFieldLogic : MonoBehaviour
{
    public TMP_InputField inputField;

    public TextMeshProUGUI text;

    private bool canAccept = false;

    private void Update()
    {
        
    }

    public void AcceptText()
    {
        if (inputField.text != "")
        {
            canAccept = true;
        }
        else
        {
            canAccept = false;
            text.text = "You need a name to continue";
        }
        if (canAccept)
        {
            text.text = $"Hello, {inputField.text} and welcome to this amazing world!";
        }
    }
}
