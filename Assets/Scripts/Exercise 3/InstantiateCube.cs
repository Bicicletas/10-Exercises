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
        // Every time you hit the Return key it activates a function
        if (Input.GetKeyDown(KeyCode.Return))
        {
            RandomPos();
        }
    }

    // Function that transforms X and the Y vectors in a random position in the scene boundries
    private void RandomPos()
    {
        float XRandomIndex = Random.Range(-XBound, XBound);

        float YRandomIndex = Random.Range(lowBoundY, highBoundY);

        cube.transform.position = new Vector3(XRandomIndex, YRandomIndex, 0);
    }
}
