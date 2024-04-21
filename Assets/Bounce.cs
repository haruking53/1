using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    public float bounce=10.0f;
    public int scorePoint=10;
    public GameObject gameManager;

    private void Start()
    {
        gameManager=GameObject.Find("GameManager");
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag=="Ball")
        {
            Vector3 normDir=other.contacts[0].normal;
            Vector3 velo=new Vector3(-normDir.x,0f,-normDir.z);
            other.rigidbody.AddForce(velo.normalized*bounce,ForceMode.VelocityChange);
        
        gameManager.GetComponent<GameManager>().AddScore(scorePoint);
        }
    }
}
