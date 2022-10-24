using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SphereCounter : MonoBehaviour
{
    private int counter = 0;

    public TextMeshProUGUI counterText;

    public GameObject[] spheres;

    public Camera camera;

    private void Update()
    {
        // If you hit the left button of the mouse it launches a ray foreward from the position of the mouse
        // until it hits something, then deactivates the object and it adds 1 to the counter variable
        if (Input.GetMouseButtonDown(0)) 
        {
            RaycastHit hit;
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                GameObject objectHit = hit.collider.gameObject;

                objectHit.SetActive(false);
                counter++;
                counterText.text = $"{counter}";
            }
        }
        // Extra stuff to reset the game
        if(counter == 30)
        {
            StartCoroutine(Reset());
        }
    }
    private IEnumerator Reset()
    {
        yield return new WaitForSeconds(2);
        counter = 0;
        counterText.text = $"{counter}";
        yield return new WaitForSeconds(2);
        foreach (GameObject array in spheres)
        {
            array.SetActive(true);
        }
    }
}
