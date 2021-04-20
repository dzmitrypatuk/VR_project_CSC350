﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubePointer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Response Pointer Touch the Cube
    public void PointerEnter()
    {
        // Change the color of the cube to red
        GetComponent<Renderer>().material.color = Color.red;

    }
    // Response Pointer Exit the Cube
    public void PointExit()
    {
        // Change the color of the cube to blue
        GetComponent<Renderer>().material.color = Color.blue;

    }
    // Response 
    public void PointerClick()
    {
        Destroy(gameObject);
    }

}
