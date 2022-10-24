using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightOnOff : MonoBehaviour
{
    public GameObject light;

    // Function created for a toggle that activates and deactivates a light
    public void OnOff(bool b)
    {
        light.SetActive(b);
    }
}
