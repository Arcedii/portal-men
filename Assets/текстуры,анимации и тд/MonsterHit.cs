using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterHit : MonoBehaviour
{
    private string closeTrigger = "walk";
    private string openTrigger = "hit";
    public Animator MonsterAnimator;

    private void OnTriggerEnter(Collider other)
    {
        MonsterAnimator.SetTrigger(openTrigger);

    }
    private void OnTriggerExit(Collider other)
    {
        MonsterAnimator.SetTrigger(closeTrigger);
    }
}
