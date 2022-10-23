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

        sphere.transform.localScale = new Vector3(slider.value, slider.value, slider.value);
    }
}
