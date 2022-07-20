using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogDethMan : MonoBehaviour
{
    [SerializeField]
    Animator CameraAnimator;
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
            delegate { Destroy(); }));

      
        Destroy(Trig);

    }
    IEnumerator WaitOnAnimation()
    {
        CameraAnimator.SetTrigger(openTrigger);
        yield return new WaitForEndOfFrame();
        while (CameraAnimator.GetCurrentAnimatorStateInfo(0).normalizedTime < 1)
        {
            yield return null;

        }
        player.gameObject.SetActive(true);
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
    void Destroy()
    {
        player.gameObject.SetActive(true);
        Destroy(movieCamera);
    }
   
}
