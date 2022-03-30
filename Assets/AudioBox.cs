using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioBox : MonoBehaviour
{
    [SerializeField]
    AudioSource AudioSource;
    string noteTag = "Box";
    void Start()
    {
        AudioSource = gameObject.GetComponent<AudioSource>();
    }

   


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(noteTag))
        {

            AudioSource.enabled = true;
            AudioSource.Play();
        }
    }

   
}
