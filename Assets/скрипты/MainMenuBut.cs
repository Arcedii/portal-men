using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuBut : MonoBehaviour
{
    public Canvas MainMenu;
    public Button mainMenu;
    public Button Back;

     void Start()
     {
        mainMenu.onClick.AddListener(OpenMenu);
        Back.onClick.AddListener(CloseMenu);
        MainMenu.gameObject.SetActive(false);
     }
    void OpenMenu()
    {
        MainMenu.gameObject.SetActive(true);
    }

    void CloseMenu()
    {
        MainMenu.gameObject.SetActive(false);
    }
}
