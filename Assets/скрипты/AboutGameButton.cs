using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AboutGameButton : MonoBehaviour
{
    public Button LilacHunter;
    public Button Arcedii;
    public Button Bohne;

    private void Start()
    {
        LilacHunter.onClick.AddListener(LiLacHunter);
        Arcedii.onClick.AddListener(I);
        Bohne.onClick.AddListener(Eugen);
    }
    void I()
    {
        Application.OpenURL("https://www.instagram.com/arcedii_officciall/");
    }    
    void Eugen()
    {
        Application.OpenURL("https://bohne1337.artstation.com/");
    }
    void LiLacHunter()
    {
        Application.OpenURL("https://play.google.com/store/apps/details?id=com.GameBIT.lilachunterAlpha");
    }
}
