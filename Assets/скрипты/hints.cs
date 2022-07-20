using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hints : MonoBehaviour
{
    public Button OpenHints;
    public Button CloseHints;
    public Image  ObjectHints;

    private void Start()
    {       
        CloseHints.gameObject.SetActive(false);
        ObjectHints.gameObject.SetActive(false);

        OpenHints.onClick.AddListener(OnImage);
        CloseHints.onClick.AddListener(OfImage);
    }

    void OnImage()
    {
        CloseHints.gameObject.SetActive(true);
        ObjectHints.gameObject.SetActive(true);
    }

    void OfImage()
    {
        CloseHints.gameObject.SetActive(false);
        ObjectHints.gameObject.SetActive(false);
    }
}
