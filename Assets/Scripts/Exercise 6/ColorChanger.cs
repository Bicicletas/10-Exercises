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
        cylinderMat.color = color[dropdown.value];
    }
    public void ColorSwitcher()
    {
        cylinderMat.color = color[dropdown.value];
    }

}
