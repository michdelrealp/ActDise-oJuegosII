using UnityEngine;

public class DeteccionColision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Verifica si el personaje toca el suelo
        if (collision.gameObject.CompareTag("Suelo"))
        {
            Debug.Log("El personaje ha tocado el suelo.");
        }

        // Verifica si el personaje choca con una pared
        if (collision.gameObject.CompareTag("Pared"))
        {
            Debug.Log("El personaje ha chocado con una pared.");
        }
    }
}
