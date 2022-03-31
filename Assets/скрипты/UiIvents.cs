using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiIvents : MonoBehaviour
{
    public Action OnButtonHold;
    string s = "djafjfa";
    public void ButtonHold()
    {
        OnButtonHold?.Invoke();
        Debug.Log(s);
    }

}
