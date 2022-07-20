using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DethSee : MonoBehaviour
{
   
   
    public GameObject Player;
    public Canvas PlayerCanvas;
    public Canvas DethScreen;
    public AudioSource Squik;
    public BoxCollider Trigger;
 
    private void Start()
    {
        DethScreen.gameObject.SetActive(false);
    }
    private void OnTriggerEnter(Collider  other)
    {
        Squik.Play();
        Death();
      
    }
  
    void Death()
    {

        // Player.gameObject.SetActive(false);
        Time.timeScale = 0f;
        PlayerCanvas.gameObject.SetActive(false);
        DethScreen.gameObject.SetActive(true);
       
    }

   
}
