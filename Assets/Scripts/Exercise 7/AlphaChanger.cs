using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlphaChanger : MonoBehaviour
{
    public Material sphereMat;

    private Color color;
    
    private void Start()
    {
        // At the start it set the color of the material to a new color variable (i don't realy know why you have to do this)  :)
        color = sphereMat.color;
    }

    // Function created for a slider that grabs the alpha of the color variable and
    //makes it be controlled by the slider, which has the values go from 0 to 1
    public void AlphaController(float f)
    {
        color.a = f;
        sphereMat.color = color;
    }
}
