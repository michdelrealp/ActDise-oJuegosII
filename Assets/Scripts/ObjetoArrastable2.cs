using UnityEngine;
using UnityEngine.EventSystems;

public class ArrastrarObjetoDos : MonoBehaviour, IDragHandler
{
    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }
}
