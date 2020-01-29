using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallAndDestroy : MonoBehaviour
{
    public GameObject cubePrefab;
    Vector3 spawnPos;
    System.Random cubePicker = new System.Random();
    int numPicked;
    private void Awake()
    {
        spawnPos = transform.position;
    }
    void Start()
    {
        InvokeRepeating("createNewCube", 1.0f, 3.0f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "destroyer")
        {
            Destroy(gameObject);
        }
    }

    void createNewCube()
    {
        numPicked = cubePicker.Next(0, 4);

        switch (numPicked)
        {
            
        
        }
        Instantiate(cubePrefab, spawnPos, cubePrefab.transform.rotation);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
