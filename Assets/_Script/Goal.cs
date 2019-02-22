using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    //A static field accessible by code anywhere
    static public bool goalMet = false;

    void OnTriggerEnter(Collider other)
    {
        //When trigger is hit by something
        //Check to see if it's projectile
        if (other.gameObject.tag == "Projectile")
        {
            //If so, set goalMet to true
            Goal.goalMet = true;
            //Also set the alpha of the color to higher opacity
            Material mat = GetComponent<Renderer>().material;
            Color c = mat.color;
            c.a = 1;
            mat.color = c;
        }
    }


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
