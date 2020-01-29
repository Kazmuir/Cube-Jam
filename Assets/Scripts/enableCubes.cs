using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enableCubes : MonoBehaviour
{
    const float Y = 22.31f;
    const float Z = -3.227299f;

    public GameObject cubePrefab;
   
    Vector3[] cubePosition = new[] { new Vector3(-12.99587f, Y, Z), new Vector3(-6.615867f, Y, Z), new Vector3(0.03413343f, Y, Z), new Vector3(6.554133f, Y, Z), new Vector3(13.03413f, Y, Z) };
    System.Random cubePicker = new System.Random();

    int numPicked;
    int lastNumPicked = -1;
    void Start()
    {
        InvokeRepeating("createNewCube", 1.0f, 0.5f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "destroyer")
        {
            Destroy(gameObject);
        }
    }

    void createNewCube()
    {
        numPicked = cubePicker.Next(0, 5);
        if(numPicked != lastNumPicked)
        {
            lastNumPicked = numPicked;
            Instantiate(cubePrefab, cubePosition[numPicked], cubePrefab.transform.rotation);
        }
        else
        {
            numPicked = cubePicker.Next(0, 5);
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
