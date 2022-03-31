using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Ladder : MonoBehaviour
{
    [SerializeField]
    Canvas Message;
    public Button ET;
    public bool isLadder;
    public GameObject player;
    float speed = 5;
   

    void Start()
    {

        ET.onClick.AddListener(UP);
        Message.gameObject.SetActive(false);
    }

   
    void OnTriggerEnter(Collider other)
    {
       if (other.gameObject.CompareTag("Player"))
       {
            Message.gameObject.SetActive(true);
            isLadder = true;
            other.attachedRigidbody.useGravity = false;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Message.gameObject.SetActive(false);
            isLadder = false;
            other.attachedRigidbody.useGravity = true;
        }
    }

   public void UP()
   {
        if (isLadder)
        {
           player.transform.Translate(Vector3.up * Time.deltaTime * speed, Space.World);
           
        }
          
      
   }
}
