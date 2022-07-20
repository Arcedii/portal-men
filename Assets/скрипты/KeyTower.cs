using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyTower : MonoBehaviour
{
    public Image ImageKey;
    public Canvas Key;
    public Button Keybut;
    public BoxCollider TrigDoor;
    public BoxCollider TrigDoorMessage;
    public GameObject key;

    void Start()
    {
        Keybut.onClick.AddListener(KeyTake);
        ImageKey.gameObject.SetActive(false);
        Key.gameObject.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        Key.gameObject.SetActive(true);

    }
    private void OnTriggerExit(Collider other)
    {
        Key.gameObject.SetActive(false);
    }

    void KeyTake()
    {
        TrigDoorMessage.gameObject.SetActive(false);
        TrigDoor.gameObject.SetActive(true);
        ImageKey.gameObject.SetActive(true);
        Key.gameObject.SetActive(false);
        Destroy(key);
    }
}
