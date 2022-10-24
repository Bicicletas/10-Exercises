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
        // Every time you press S key if a int variable, called index, is below 5 it starts a function and it adds 1 to the index
        if (Input.GetKeyDown(KeyCode.S))
        {
            if (index < 5)
            {
                InstantiateCapsule();
                index++;
            }
        }
    }
    // Function that instantiates a gameObject in a position determinated bay an array of Transforms, 5 in total
    private void InstantiateCapsule()
    {
        Instantiate(capsule, capsulesPos[index].position, transform.rotation);
    }
}
