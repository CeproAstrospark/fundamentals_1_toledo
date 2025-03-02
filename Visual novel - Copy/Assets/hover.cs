using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NewBehaviourScript : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public Animator chichi;
    private void Start()
    {
        chichi = GetComponent<Animator>();
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        chichi.SetBool("isidle", true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        chichi.SetBool("isidle", false);
    }
}
