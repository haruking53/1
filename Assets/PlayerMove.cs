using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 15f;

    private void FixedUpdate()
    {
        var veloX=speed*Input.GetAxisRaw("Horizontal");
        GetComponent<Rigidbody>().velocity=new Vector3(veloX,0f,0f);
    }
}
