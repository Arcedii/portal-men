using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Load : MonoBehaviour
{
    public GameObject LineObj;
    public Slider line;

    void Start()
    {
        StartCoroutine("LoadLevel");
    }

    IEnumerator LoadLevel()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(2);

        while(!operation.isDone)
        {
            float p = Mathf.Clamp01(operation.progress / 20f);
            line.value = p;

            yield return null;
        }
    }
}
