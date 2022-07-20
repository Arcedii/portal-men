using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPplayer : MonoBehaviour
{
    public Image Hit;
    public Canvas Deth;
    public float hp = 1;
    public Scrollbar ScrollbarHp;

    private void Start()
    {       
        Hit.gameObject.SetActive(false);
        Deth.gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Death")
        {
            HitPlayer();
            hp -= 0.2f;
            ScrollbarHp.size = hp;
            if(hp < 0.1f)
            {
                Death();
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        
        Hit.gameObject.SetActive(false);
    }

    void Death()
    {       
        Deth.gameObject.SetActive(true);
        gameObject.SetActive(false);
    }
    void HitPlayer()
    {
       
        Hit.gameObject.SetActive(true);
    }
}
