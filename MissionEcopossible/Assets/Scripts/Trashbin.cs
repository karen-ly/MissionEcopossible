using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Trashbin : MonoBehaviour, IDropHandler {
    

    // public GameObject CorrectAnswer;

    // Deal with trash item disappear here
    public void OnDrop(PointerEventData eventData) {
        Debug.Log("OnDrop");
        if (eventData.pointerDrag != null) {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;

            // if (DragHandler.DraggedItem == CorrectAnswer)
            //  {
            //      //Handle correct answer
            //  }
            //  else
            //  {
            //      //Handle incorrect answer
            //  }
            
        }
    }
}
