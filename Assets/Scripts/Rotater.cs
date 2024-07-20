using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Rotater : MonoBehaviour
{
   [SerializeField] Vector3 direction;

   
    void Update()
    {
        transform.Rotate(direction);
    }
}
