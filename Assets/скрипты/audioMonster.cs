using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioMonster : MonoBehaviour
{
   
   public AudioSource Audio;

    private void OnTriggerEnter(Collider other)
    {
        Audio.Play();
    }
    private void OnTriggerExit(Collider other)
    {
        Audio.Stop();
    }
}
