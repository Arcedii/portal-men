using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateTrigger : MonoBehaviour
{
    [SerializeField]
    Animator CameraAnimator;
    [SerializeField]
    Rigidbody[] rigidbodiesList;
    [SerializeField]
    BoxCollider Trig;
    [SerializeField]
    AudioSource Voice;
    private string openTrigger = "on";
    [SerializeField]
    GameObject player;
    [SerializeField]
    GameObject movieCamera;


    void Start()
    {
        Voice = gameObject.GetComponent<AudioSource>();
        EnableBox(false);
        player.gameObject.SetActive(true);
        movieCamera.gameObject.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        player.gameObject.SetActive(false);
        movieCamera.gameObject.SetActive(true);
        Voice.enabled = true;
        StartCoroutine(WaitOnAudio());      
        CameraAnimator.SetTrigger(openTrigger);
        EnableBox(true);
        Destroy(Trig);
      
    }
    private void OnTriggerExit(Collider other)
    {
        player.gameObject.SetActive(true);
    }



    IEnumerator WaitOnAudio()
    {
        if (Voice.isPlaying)
        {
            yield break;
        }
        Voice.Play();
        while(Voice.isPlaying)
        {
            yield return null;
        }
        Voice.enabled = false;
    }

     void EnableBox(bool state)
     {
        foreach (var box in rigidbodiesList)
        {
            box.gameObject.SetActive(state);
        }
      
     }
}
