using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinning_floating_cube : MonoBehaviour
{
    public float rotationSpeed = 50f;
    public float floatSpeed = 0.5f;
    public float floatHeight = 0.3f;

    // Position Storage Variables
    Vector3 startingPos = new Vector3();
    Vector3 newPos = new Vector3();

    void Start()
    {
        startingPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);



        newPos = startingPos;
        newPos.y += Mathf.Sin(Time.fixedTime * Mathf.PI * floatSpeed) * floatHeight;

        transform.position = newPos;

    }
}
