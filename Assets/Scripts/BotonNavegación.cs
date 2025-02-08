using UnityEngine;
using UnityEngine.SceneManagement; // Necesario para cambiar de escena

public class BotonNavegacion : MonoBehaviour
{
    public void CargarEscena(string nombreEscena)
    {
        SceneManager.LoadScene(nombreEscena);
    }

    public void SalirDelJuego()
    {
        Application.Quit(); // Cierra la aplicación
    }
}
