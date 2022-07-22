using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screamer : MonoBehaviour
{
    [SerializeField]
    Animator ScreamerAnim;
    [SerializeField]
    GameObject Monster;
    private string openTrigger = "on";
    [SerializeField]
    BoxCollider Trig;

    private void Start()
    {
        Monster.gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        Monster.gameObject.SetActive(true);
        StartCoroutine(WaitOnAnimation());       
        Destroy(Trig);
    }
    IEnumerator WaitOnAnimation()
    {
        ScreamerAnim.SetTrigger(openTrigger);
        yield return new WaitForEndOfFrame();
        while (ScreamerAnim.GetCurrentAnimatorStateInfo(0).normalizedTime < 1)
        {
            yield return null;

        }
        Destroy(Monster);
    }
}
