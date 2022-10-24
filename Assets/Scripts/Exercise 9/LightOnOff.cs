using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightOnOff : MonoBehaviour
{
    public GameObject light;

    public void OnOff(bool b)
    {
        light.SetActive(b);
    }
}
