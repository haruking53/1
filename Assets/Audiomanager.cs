using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audiomanager : MonoBehaviour
{
private AudioSource audioSource;

   public AudioClip sound01;
   public AudioClip sound02;
   public AudioClip sound03;

void Start()
{
    audioSource=gameObject.AddComponent<AudioSource>();
}

void OnCollisionEnter(Collision other)
{
    GameObject gameManager=GameObject.Find("GameManager");
    if(gameManager.GetComponent<GameManager>().CheckinGame())
    {
    if(other.gameObject.tag=="Player")
    {
        audioSource.PlayOneShot(sound01);
    }

    else if(other.gameObject.tag=="Target")
    {
        audioSource.PlayOneShot(sound02);
    }
    
    else audioSource.PlayOneShot(sound03);
    }
}
}

