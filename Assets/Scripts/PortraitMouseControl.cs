using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class PortraitMouseControl : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Mouse Over : " + transform.GetChild(2).GetComponent<TextMeshProUGUI>().text);
        ExplanationPanel.ShowExplanationPanel(transform.GetChild(2).GetComponent<TextMeshProUGUI>().text);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("Mouse Exit");
        ExplanationPanel.HideExplanationPanel();
    }
}
