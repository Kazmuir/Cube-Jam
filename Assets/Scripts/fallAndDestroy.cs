using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallAndDestroy : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "destroyer")
        {
            Destroy(gameObject);
        }
    }
    void Update()
    {

    }
}
