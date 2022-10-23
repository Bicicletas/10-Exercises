using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleArray : MonoBehaviour
{
    public Transform[] capsulesPos;

    public GameObject capsule;

    private int index = 0;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            if (index < 5)
            {
                InstantiateCapsule();
                index++;
            }
        }
    }

    private void InstantiateCapsule()
    {
        Instantiate(capsule, capsulesPos[index].position, transform.rotation);
    }
}
