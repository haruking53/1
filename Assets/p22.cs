using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p22 : MonoBehaviour
{
    public float speed =2.0f;
   
    private Rigidbody rB;
    
    void Start()
    {
        rB=GetComponent<Rigidbody>();
    }

    void Update()
    {
        
        float x=Input.GetAxis("Horizontal");
        float z=Input.GetAxis("Vertical");
        

        rB.AddForce(x*speed,0f,z*speed,ForceMode.Impulse);
    }
}
