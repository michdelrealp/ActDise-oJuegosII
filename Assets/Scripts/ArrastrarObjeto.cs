using UnityEngine;

public class ArrastrarObjeto : MonoBehaviour
{
    private bool siendoArrastrado = false;

    void OnMouseDown()
    {
        Debug.Log("Clic detectado en " + gameObject.name);
        siendoArrastrado = true;
    }

    void OnMouseUp()
    {
        siendoArrastrado = false;
    }

    void Update()
    {
        if (siendoArrastrado)
        {
            if (Camera.main == null)
            {
                Debug.LogError("No hay una Main Camera en la escena.");
                return;
            }

            Vector2 posicionMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = posicionMouse;
        }
    }
}
