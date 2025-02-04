using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class InterfazControlador : MonoBehaviour
{
    public Button boton1;
    public Button boton2;
    public Button boton3;
    public TextMeshProUGUI enlace1;
    public TextMeshProUGUI enlace2;
    public TextMeshProUGUI enlace3;
    public TextMeshProUGUI enlace4;

    void Start()
    {
        // Verificamos que los botones no sean null antes de asignar eventos
        if (boton1 != null)
            boton1.onClick.AddListener(() => BotonPresionado("Botón 1 presionado"));

        if (boton2 != null)
            boton2.onClick.AddListener(() => BotonPresionado("Botón 2 presionado"));

        if (boton3 != null)
            boton3.onClick.AddListener(() => BotonPresionado("Botón 3 presionado"));

        // Configurar enlaces si es necesario
        if (enlace1 != null) enlace1.text = "<color=blue><u>https://www.instagram.com/michdelreal/</u></color>";
        if (enlace2 != null) enlace2.text = "<color=blue><u>https://kick.com/cry</u></color>";
        if (enlace3 != null) enlace3.text = "<color=blue><u>https://www.tiktok.com/@michdelrealp</u></color>";
        if (enlace4 != null) enlace4.text = "<color=blue><u>https://open.spotify.com/user/12169401795</u></color>";
    }

    void BotonPresionado(string mensaje)
    {
        Debug.Log(mensaje);
    }
}

