using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControladorInterfaz : MonoBehaviour
{
    public Button boton1;
    public Button boton2;
    public Button boton3;

    void Start()
    {
        boton1.onClick.AddListener(() => CambiarEscena("Escena2"));
        boton2.onClick.AddListener(() => CambiarEscena("Escena3"));
        boton3.onClick.AddListener(SalirJuego);
    }

    void CambiarEscena(string nombreEscena)
    {
        SceneManager.LoadScene(nombreEscena);
    }

    void SalirJuego()
    {
        Application.Quit();
    }
}
