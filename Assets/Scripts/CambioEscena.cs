using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscena : MonoBehaviour
{
    public void CambiarEscena(string nombreEscena)
    {
        if (Application.CanStreamedLevelBeLoaded(nombreEscena))
        {
            SceneManager.LoadScene(nombreEscena);
        }
        else
        {
            Debug.LogError("La escena '" + nombreEscena + "' no est� en Build Settings o el nombre es incorrecto.");
        }
    }
}
