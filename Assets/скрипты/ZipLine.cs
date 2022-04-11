using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZipLine : MonoBehaviour
{
    [SerializeField]
    Animator  ZipLineAnimator;
    [SerializeField]
    Button but; 
    [SerializeField]
    Canvas DoorMessage; 
    float speed = 1;
    private string openTrigger = "open";
    public  Rigidbody rb;
    public Joystick Move;






    void Start()
    {
       

        but.onClick.AddListener(delegate {
            StartCoroutine(ZipLineAnimator.WaitOnAnimationCoroutine(ZipLine1, EnableInputAfterAnim));
        });
        DoorMessage.gameObject.SetActive(false);
    }

    void EnableInputAfterAnim()
    {
       EnableInput(true); 
    }

   

    private void OnTriggerEnter(Collider other)
    {
        DoorMessage.gameObject.SetActive(true);
      
    }
    private void OnTriggerExit(Collider other)
    {
        DoorMessage.gameObject.SetActive(false);
      
    }

    void ZipLine1()
    {     
        if (ZipLineAnimator == true)
        {
            EnableInput(false);
        }

        ZipLineAnimator.SetTrigger(openTrigger);
    }

    private void EnableInput(bool state)
    {
        ZipLineAnimator.enabled = !state;
        rb.GetComponent<Rigidbody>().useGravity = state;
        Move.gameObject.SetActive(state);
    }

    private void OnDestroy()
    {

        if (DoorMessage)
        {
            DoorMessage.gameObject.SetActive(false);
        }


    }
     

}
