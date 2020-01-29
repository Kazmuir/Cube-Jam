using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class assignLane : MonoBehaviour
{
    //public AudioClip A;
    //public AudioClip B;
    //public AudioClip C;
    //public AudioClip D;
    //public AudioClip E;

    private void OnTriggerEnter(Collider cube)
    {
        if(this.gameObject.tag == "lane0")
        {
            print("this cube is in lane 0");
            //cube.gameObject.GetComponent<AudioSource>().clip = A;
        }
        else if (this.gameObject.tag == "lane1")
        {
            print("this cube is in lane 1");
            //cube.gameObject.GetComponent<AudioSource>().clip = B;
        }
        else if (this.gameObject.tag == "lane2")
        {
            print("this cube is in lane 2");
            //cube.gameObject.GetComponent<AudioSource>().clip = C;
        }
        else if (this.gameObject.tag == "lane3")
        {
            print("this cube is in lane 3");
            //cube.gameObject.GetComponent<AudioSource>().clip = D;
        }
        else if (this.gameObject.tag == "lane4")
        {
            print("this cube is in lane 4");
            //cube.gameObject.GetComponent<AudioSource>().clip = E;
        }
        else
        {
            print("I detect nothing");
        }
    }
    // Update is called once per frame

}
