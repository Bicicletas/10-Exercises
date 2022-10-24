using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SphereCounter : MonoBehaviour
{
    private int counter = 0;

    public TextMeshProUGUI counterText;

    private void Update()
    {
        counter = PlayerPrefs.GetInt("counter");
        counterText.text = $"{PlayerPrefs.GetInt("counter")}";
    }
    private void OnMouseDown()
    {
        gameObject.SetActive(false);
        counter++;
        PlayerPrefs.SetInt("counter", counter);
    }
    private void OnApplicationQuit()
    {
        counter = 0;
        PlayerPrefs.SetInt("counter", counter);
    }
}
