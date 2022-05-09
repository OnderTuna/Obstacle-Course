using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody myRigidbody;
    [SerializeField] float time = 3.0f;

    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        renderer.enabled = false;
        myRigidbody = GetComponent<Rigidbody>();
        myRigidbody.useGravity = false;
    }
    
    void Update()
    {
        if(Time.time > time)
        {
            renderer.enabled = true;
            myRigidbody.useGravity = true;
        }
    }
}
