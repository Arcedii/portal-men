using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Map: MonoBehaviour
{
   public  Button map;
   public Button take1;
   public  Canvas take;
   public BoxCollider trig;
    public GameObject mapObject;

    void Start()
    {
        take.gameObject.SetActive(false);
        map.gameObject.SetActive(false);
        take1.onClick.AddListener(Take);
    }

    void Take()
    {
        map.gameObject.SetActive(true);
        take1.gameObject.SetActive(false);
        Destroy(trig);
        Destroy(mapObject);
    }

     void OnTriggerEnter(Collider other)
     {
        take.gameObject.SetActive(true);
     }
   
     void OnTriggerExit(Collider other)
     {
        take.gameObject.SetActive(false);
     }
}
