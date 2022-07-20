using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorWithoutFuse : MonoBehaviour
{
    public Canvas Canv;

    private void Start()
    {
        Canv.gameObject.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        Canv.gameObject.SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {
        Canv.gameObject.SetActive(false);
    }
}
