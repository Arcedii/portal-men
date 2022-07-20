using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AboutAutohrs : MonoBehaviour
{
    public Button OpenAuthors;
    public Button CloseAuthors;
    public Canvas AboutGame;
       
    
    void Start()
    {
        OpenAuthors.onClick.AddListener(Open);
        CloseAuthors.onClick.AddListener(Close);
        AboutGame.gameObject.SetActive(false);
    }

    void Open()
    {
        AboutGame.gameObject.SetActive(true);
    }
    void Close()
    {
        AboutGame.gameObject.SetActive(false);
    }
}
