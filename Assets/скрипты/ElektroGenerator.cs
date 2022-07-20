using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ElektroGenerator : MonoBehaviour
{
    public GameObject ps;
    public GameObject Audio;
    public GameObject Fuse;
    public Canvas AddFuse;
    public Button but;
    public BoxCollider Trig;
    public GameObject Light;
    public GameObject Light1;
    public GameObject Light2;
    public GameObject Light3;
    public GameObject Light4;

    void Awake()
    {
        Fuse.gameObject.SetActive(false);
        AddFuse.gameObject.SetActive(false);
        Audio.gameObject.SetActive(false);
        ps.gameObject.SetActive(true);

        Light.gameObject.SetActive(false);
        Light1.gameObject.SetActive(false);
        Light2.gameObject.SetActive(false);
        Light3.gameObject.SetActive(false);
        Light4.gameObject.SetActive(false);

        but.onClick.AddListener(On);
    }
    private void OnTriggerEnter(Collider other)
    {
        AddFuse.gameObject.SetActive(true);
        but.gameObject.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        AddFuse.gameObject.SetActive(false);
        but.gameObject.SetActive(false);
    }

    void On()
    {
        Fuse.gameObject.SetActive(true);
       
        Light.gameObject.SetActive(true);
        Light1.gameObject.SetActive(true);
        Light2.gameObject.SetActive(true);
        Light3.gameObject.SetActive(true);
        Light4.gameObject.SetActive(true);
        ps.gameObject.SetActive(false);
        AddFuse.gameObject.SetActive(false);
        but.gameObject.SetActive(false);
        Audio.gameObject.SetActive(false);
        Destroy(Trig);
        
    }
}
