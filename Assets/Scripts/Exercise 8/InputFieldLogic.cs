using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InputFieldLogic : MonoBehaviour
{
    public TMP_InputField inputField;

    public TextMeshProUGUI text;

    private bool canAccept = false;

    // Function created for a button that displays an input filed text on a text UI if there is at least 1 character
    // (to make sure that there isn't anything but blank spaces I set the input field values to not allow blanks (Alphanumeric))
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
