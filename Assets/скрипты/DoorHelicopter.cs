using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorHelicopter : MonoBehaviour
{
    [SerializeField]
    Animator DoorHelicopterAnimator;
    [SerializeField]
    Button but;
    private string openTrigger = "openn";
    [SerializeField]
    BoxCollider Trig;
    [SerializeField]
    Canvas DoorMessage;
    [SerializeField]
    AudioSource squeak;
    void Start()
    {
        but.onClick.AddListener(DoorOpen);
        but.gameObject.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        but.gameObject.SetActive(true);

    }
    private void OnTriggerExit(Collider other)
    {
        but.gameObject.SetActive(false);

    }
    void DoorOpen()
    {
        DoorHelicopterAnimator.SetTrigger(openTrigger);
        squeak.Play();
        Destroy(Trig);
        Destroy(DoorMessage);
    }
}
