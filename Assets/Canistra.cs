using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canistra : MonoBehaviour
{
    public AudioSource Sound;
    public BoxCollider Trig;
    public Rigidbody[] rigidbodiesList;

    private void Start()
    {
        EnableBox(false);
    }

    void OnTriggerEnter(Collider other)
    {
        EnableBox(true);
        Sound.Play();
        Destroy(Trig);
    }
    void EnableBox(bool state)
    {
        foreach (var box in rigidbodiesList)
        {
            box.gameObject.SetActive(state);
        }

    }
}
