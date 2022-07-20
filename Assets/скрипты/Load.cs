using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Load : MonoBehaviour
{

    public GameObject Scene;
    public GameObject LineObj;
    public Slider line;
    public float maxLoadTime = 5;
    float loadTime = 0f;

    void Start()
    {
        StartCoroutine("LoadLevel");
    }

    IEnumerator LoadLevel()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(2, LoadSceneMode.Additive);

        operation.allowSceneActivation = false;

        while(loadTime < maxLoadTime)
        {
            loadTime += Time.deltaTime;
            line.value = NormalizeNumber(loadTime, 5, 0);

            yield return null;
        }

        operation.allowSceneActivation = true;
     
        yield return null;

        SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene().buildIndex);
        
        Scene.gameObject.SetActive(false);


    }

    float NormalizeNumber(float value, float max, float min)
    {
        return (value - min) / (max - min);
    }
}
