using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapON : MonoBehaviour
{
   public Button on;
   public Image Map;
    public Button of;

    void Start()
    {
        of.onClick.AddListener(Of);
        on.onClick.AddListener(On);
        Map.gameObject.SetActive(false);
        of.gameObject.SetActive(false);
       
    }


   
    
    void On()
    {
        of.gameObject.SetActive(true);
        Map.gameObject.SetActive(true);
        on.gameObject.SetActive(false);
    }

    void Of()
    {
        of.gameObject.SetActive(false);
        Map.gameObject.SetActive(false);
        on.gameObject.SetActive(true);
    }
}
