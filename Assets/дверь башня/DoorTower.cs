using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DoorTower : MonoBehaviour
{
    [SerializeField]
    Animator DoorHelicopterAnimator;
    [SerializeField]
    Button but;
    private string openTrigger = "openn";
    private string openTrigger2 = "opendoor";
    [SerializeField]
    BoxCollider Trig;
    [SerializeField]
    Canvas DoorMessage;
    [SerializeField]
    AudioSource squeak;
    GameObject Lock;
    void Start()
    {
        Trig.gameObject.SetActive(false);
        DoorMessage.gameObject.SetActive(false);
        but.onClick.AddListener(DoorOpen);
        but.gameObject.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        DoorMessage.gameObject.SetActive(true);
        but.gameObject.SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {
        DoorMessage.gameObject.SetActive(false);
        but.gameObject.SetActive(false);
    }
    void DoorOpen()
    {
        DoorHelicopterAnimator.SetTrigger(openTrigger);
        Destroy(Trig);
        Destroy(Lock);
        Destroy(DoorMessage);
        if (Trig == false)
        {
            squeak.Play();
            DoorHelicopterAnimator.SetTrigger(openTrigger2);

        }
     
     
    }
}
