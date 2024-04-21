using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Changesize : MonoBehaviour
{
   void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag=="Player")
        {
            GetComponent<Transform>().localScale=new Vector3(0.5f,1.0f,0.5f);
}
    }
}
