using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontrols : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      // this code makes the tanks move 
        transform.Translate(Vector3.forward*Time.deltaTime*20);
    }
}
