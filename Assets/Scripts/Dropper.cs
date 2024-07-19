using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer meshrenderer;
    Rigidbody rbody;
    
    [SerializeField] float timeTowait = 5f;
   

    void Start()
    {
        meshrenderer = GetComponent<MeshRenderer>();
        rbody = GetComponent<Rigidbody>();

        meshrenderer.enabled = false;
        rbody.useGravity = false;
    }

   
   void Update()
    {      
        if(Time.time > timeTowait)
        {
             meshrenderer.enabled = true;
             rbody.useGravity = true;
        }
    }
}
