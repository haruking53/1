using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Broken2 : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag=="Ball")
        {
            Destroy(other.gameObject,0.1f);
        }
    }
}

