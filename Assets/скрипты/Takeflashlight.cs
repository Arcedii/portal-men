using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Takeflashlight : MonoBehaviour
{
    [SerializeField]
    Button on;
    public Collider Player;
    public GameObject deletedFlashLight;
    public GameObject flashlight;

    void Start()
    {
        on.gameObject.SetActive(false);
    }
    private void OnTriggerEnter()
    {      
       on.gameObject.SetActive(true);
       deletedFlashLight.SetActive(false);
       flashlight.SetActive(true);
            
         
    }

}
