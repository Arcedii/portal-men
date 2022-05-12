using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraSofa : MonoBehaviour
{
    public Animator CameraAnimator;
    public BoxCollider Trig;
    public Button SitDown;
    public  Button GetUp;
    public AudioSource Voice;
    private string openTrigger = "on";
    private string openTrigger2 = "on2";

    public GameObject player;
    public GameObject movieCamera;
   


    void Start()
    {
        SitDown.onClick.AddListener(StartAnim);
        GetUp.onClick.AddListener(LastAnim);

        GetUp.gameObject.SetActive(false);
        SitDown.gameObject.SetActive(false);

        player.gameObject.SetActive(true);
        movieCamera.gameObject.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        SitDown.gameObject.SetActive(true);

    }
    private void OnTriggerExit(Collider other)
    {
        SitDown.gameObject.SetActive(false);

    }
   

    void StartAnim()
    {
        player.gameObject.SetActive(false);
        movieCamera.gameObject.SetActive(true);
        Voice.enabled = true;
        StartCoroutine(WaitOnAudio());
        StartCoroutine(
            CameraAnimator.WaitOnAnimationCoroutine(
            delegate { CameraAnimator.SetTrigger(openTrigger); },
            delegate { GetUp.gameObject.SetActive(true); }));

        SitDown.gameObject.SetActive(false);
        Destroy(Trig);   
    }

    void LastAnim()
    {
        StartCoroutine(
           CameraAnimator.WaitOnAnimationCoroutine(
           delegate { CameraAnimator.SetTrigger(openTrigger2); },
           delegate { player.gameObject.SetActive(true); }));

        GetUp.gameObject.SetActive(false);
      
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
