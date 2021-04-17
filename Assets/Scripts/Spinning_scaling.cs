using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinning_scaling : MonoBehaviour
{

    public float rotationSpeed = 50f;
    public float scaleSpeed = 0.2f;
    public float scaleAmount = 1f;

    // Scaling Storage Variables
    Vector3 startingScale = new Vector3();
    Vector3 newScale = new Vector3();

    void Start()
    {
        startingScale = transform.localScale;
    }
    void Update()
    {
        transform.Rotate(0, rotationSpeed * Time.deltaTime, rotationSpeed * Time.deltaTime);

        newScale = startingScale;

        newScale.y += Mathf.Sin(Time.fixedTime * Mathf.PI * scaleSpeed) * scaleAmount;
        newScale.x += Mathf.Sin(Time.fixedTime * Mathf.PI * scaleSpeed) * scaleAmount;
        newScale.z += Mathf.Sin(Time.fixedTime * Mathf.PI * scaleSpeed) * scaleAmount;
        if (newScale.y >= 0)
        {
            transform.localScale = newScale;
        }


    }
}
