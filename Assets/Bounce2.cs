using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce2 : MonoBehaviour
{
    public float bounce=5.0f;
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag=="Ball")
        {
            Vector3 normDir=other.contacts[0].normal;
            Vector3 velo=new Vector3(-normDir.x,0f,-normDir.z);
            other.rigidbody.AddForce(velo.normalized*bounce,ForceMode.VelocityChange);
        }
    }
}
