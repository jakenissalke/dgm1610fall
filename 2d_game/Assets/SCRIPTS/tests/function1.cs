using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class function1 : MonoBehaviour
{
    int num1;
    int num2;
    int total;
    // Start is called before the first frame update
    void Start()
    {
        CalcAdd(11,23);
    }

    int CalcAdd(int n1, int n2)
    {
        Debug.Log("Number 1 =" + n1 + "Number 2= " + n2);
        total =  n1+ n2;

        return total;
        Debug.Log(total);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
