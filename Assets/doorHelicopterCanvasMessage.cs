using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class doorHelicopterCanvasMessage : MonoBehaviour
{
  
   public Canvas DoorMessage;
    void Start()
    {
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
}
