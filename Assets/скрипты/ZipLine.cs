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
            StartCoroutine(WaitOnAnimation());
        });
        DoorMessage.gameObject.SetActive(false);
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
        rb.GetComponent<Rigidbody>().useGravity = state;
        Move.gameObject.SetActive(state);
    }

    IEnumerator WaitOnAnimation()
    {
        ZipLine1();
        yield return new WaitForEndOfFrame();
        while (ZipLineAnimator.GetCurrentAnimatorStateInfo(0).normalizedTime < 1)
        {
            yield return null;

        }
        EnableInput(true);

    }

    private void OnDestroy()
    {

        if (DoorMessage)
        {
            DoorMessage.gameObject.SetActive(false);
        }


    }
     

}
