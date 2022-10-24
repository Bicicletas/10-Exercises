using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScaleSphere : MonoBehaviour
{
    public Slider slider;

    public GameObject sphere;

    private void Update()
    {
        // The scale of a sphere changes depending on the value of a slider whitch it goes from 0.5 to 5
        sphere.transform.localScale = new Vector3(slider.value, slider.value, slider.value);
    }
}
