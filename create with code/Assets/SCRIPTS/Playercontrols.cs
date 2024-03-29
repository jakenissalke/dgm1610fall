﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontrols : MonoBehaviour
{

  private float speed = 30;
  private float turnSpeed = 15f;
  private float horizontalInput;
  private float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      // this code makes the tanks move 
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput *Time.deltaTime);
    }
}
