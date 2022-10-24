using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ColorChanger : MonoBehaviour
{
    public Material cylinderMat;

    public Color[] color;

    public TMP_Dropdown dropdown;

    private void Start()
    {
        // At the begining it sets the color of a material to the default color of a dropdown
        cylinderMat.color = color[dropdown.value];
    }

    // Function created for a dropdown that changes the color of a material depending of the
    // value of the dropdown it self with an array of color in order of the dropdown
    public void ColorSwitcher()
    {
        cylinderMat.color = color[dropdown.value];
    }

}
