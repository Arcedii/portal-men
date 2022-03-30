using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Ladder2 : MonoBehaviour, IPointerDownHandler, IPointerEnterHandler, IPointerExitHandler, IPointerUpHandler
{
  
    [SerializeField] GameObject _cube;
    [SerializeField] Rigidbody _rigidbody;

    [SerializeField] bool _clicked;
    [SerializeField] bool _entered;

    void Update()
    {
        GoUp();
    }
    void GoUp()
    {
        bool isHolding = _clicked && _entered;

        _rigidbody.useGravity = !isHolding;

        if (isHolding)
        {
            _cube.transform.position += Vector3.up * Time.deltaTime * 5f;
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        _clicked = true;

        Debug.Log("Down");
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        _entered = true;
        Debug.Log("Enter");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        _entered = false;
        Debug.Log("Exit");
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        _clicked = false;
        Debug.Log("Up");
    }
}