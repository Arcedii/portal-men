using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutSceneCar : MonoBehaviour
{
    [SerializeField]
    Animator CameraAnimator;
    [SerializeField]
    BoxCollider  PS;
    [SerializeField]
    AudioSource Voice;
    private string openTrigger = "on";
    [SerializeField]
    GameObject player;
    [SerializeField]
    GameObject movieCamera;
    public GameObject Particle;
    public GameObject ParticlePlayer;



    void Start()
    {
          
        player.gameObject.SetActive(true);
        movieCamera.gameObject.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        player.gameObject.SetActive(false);
        movieCamera.gameObject.SetActive(true);
        Voice.enabled = true;

        StartCoroutine(WaitOnAudio());
        StartCoroutine(
            CameraAnimator.WaitOnAnimationCoroutine(
            delegate { CameraAnimator.SetTrigger(openTrigger); },
            delegate { player.gameObject.SetActive(true); }));

         Destroy(PS);
         Particle.gameObject.SetActive(false);
         ParticlePlayer.gameObject.SetActive(false);
    }
  
    IEnumerator WaitOnAudio()
    {
        if (Voice.isPlaying)
        {
            yield break;
        }
        Voice.Play();
        while (Voice.isPlaying)
        {
            yield return null;
        }
        Voice.enabled = false;
    }

   


}
