using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;

public class Mover : MonoBehaviour
{
    float xValue = 0;
    float yValue = 0.01f;
    float zValue = 0;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(xValue,yValue,zValue);
    }
}
