using System;
using System.Collections;
using UnityEngine;

public static class WaitOnAnimation
{
    public static IEnumerator WaitOnAnimationCoroutine(this Animator animator, Action onStart = null, Action onEnd = null)
    {
        onStart?.Invoke();
        
        yield return new WaitForEndOfFrame();
        
        while (animator.GetCurrentAnimatorStateInfo(0).normalizedTime < 1)
        {
            yield return null;
        }
        
        onEnd?.Invoke();
    }
}