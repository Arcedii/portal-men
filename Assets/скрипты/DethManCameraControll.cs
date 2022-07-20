using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DethManCameraControll : MonoBehaviour
{
  
  public  Animator CameraAnimator;
   
   public BoxCollider Trig;
    private string openTrigger = "on";
   
  public   GameObject player;
  
   public GameObject movieCamera;


    void Start()
    {
      
       
        player.gameObject.SetActive(true);
        movieCamera.gameObject.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        player.gameObject.SetActive(false);
        movieCamera.gameObject.SetActive(true);
       
       
        StartCoroutine(
            CameraAnimator.WaitOnAnimationCoroutine(
            delegate { CameraAnimator.SetTrigger(openTrigger); },
            delegate { Destroying(); }));

        
        Destroy(Trig);

    }

    void Destroying()
    {
        player.gameObject.SetActive(true);
        Destroy(movieCamera);
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




  
}
