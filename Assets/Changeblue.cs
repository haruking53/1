using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag=="Player")
        {
           GetComponent<Renderer>().material.color=Color.blue;
        }
    }
}


