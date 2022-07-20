using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Button Start;

    private void Awake()
    {
        Start.onClick.AddListener(OnClickLoadScene);
    }

    public void OnClickLoadScene()
   {

        SceneManager.LoadScene(1);
   }
}
