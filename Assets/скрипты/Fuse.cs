using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fuse : MonoBehaviour
{
    public Image F;
    public Canvas FuseCanv;
    public Button but;
    public GameObject WithoutFuse;
    public GameObject WithFuse;
    public GameObject FuseObject;

   
    void Start()
    {
        F.gameObject.SetActive(false);
        FuseCanv.gameObject.SetActive(false);
        WithFuse.gameObject.SetActive(false);
        but.onClick.AddListener(On);

    }
    private void OnTriggerEnter(Collider other)
    {
        FuseCanv.gameObject.SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {
        FuseCanv.gameObject.SetActive(false);
    }
    void On()
    {
        WithFuse.gameObject.SetActive(true);
        FuseCanv.gameObject.SetActive(false);
        but.gameObject.SetActive(false);
        F.gameObject.SetActive(true);
        Destroy(WithoutFuse);
        Destroy(FuseObject);
    }
}
