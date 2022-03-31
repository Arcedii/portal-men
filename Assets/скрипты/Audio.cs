using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    [SerializeField]
    AudioSource AudioSource;
    string noteTag = "Player";
    void Start()
    {
         AudioSource = gameObject.GetComponent<AudioSource>();
    }

  
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(noteTag))
        {

            AudioSource.enabled =true;
            AudioSource.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        AudioSource.enabled =false;
        AudioSource.Stop();
    }
}
