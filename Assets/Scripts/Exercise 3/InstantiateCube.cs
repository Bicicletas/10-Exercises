using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateCube : MonoBehaviour
{
    public GameObject cube;

    private float XBound = 7.9f;

    private float highBoundY = 5f;
    private float lowBoundY = -3f;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            RandomPos();
        }
    }

    private void RandomPos()
    {
        float XRandomIndex = Random.Range(-XBound, XBound);

        float YRandomIndex = Random.Range(lowBoundY, highBoundY);

        Instantiate(cube, new Vector3(XRandomIndex, YRandomIndex, 0), cube.transform.rotation);
    }
}
