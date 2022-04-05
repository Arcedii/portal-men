using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriigerButton : MonoBehaviour
{
    [SerializeField]
    Canvas canv;
   

    void Start()
     {
        canv.gameObject.SetActive(false);
     }
    private void OnTriggerEnter(Collider other)
    {
        canv.gameObject.SetActive(true);
      
    }
    private void OnTriggerExit(Collider other)
    {
        canv.gameObject.SetActive(false);
     
    }
}
