using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticlePlayer : MonoBehaviour
{
   public BoxCollider ParticleOn;
  public  GameObject ParticlePlayer1;

     void Start()
     {
        ParticlePlayer1.SetActive(false);
     }

    private void OnTriggerEnter(Collider ParticleOn)
    {
        ParticlePlayer1.SetActive(true);
    }
    private void OnTriggerExit(Collider ParticleOn)
    {
        ParticlePlayer1.SetActive(false);
    }
}
