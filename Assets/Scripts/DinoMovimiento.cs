using UnityEngine;

public class DinoMovimiento : MonoBehaviour
{
    public float velocidad = 5f;
    public float fuerzaSalto = 10f;
    private Rigidbody2D rb;
    private Animator anim;
    private bool enSuelo;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

        // Asegurar que la rotación está bloqueada en el eje Z
        rb.freezeRotation = true;
    }

    void Update()
    {
        float movimiento = Input.GetAxis("Horizontal");

        // Aplicar movimiento solo si se presionan teclas
        if (movimiento != 0)
        {
            rb.linearVelocity = new Vector2(movimiento * velocidad, rb.linearVelocity.y);

            // Voltear la dirección del sprite dependiendo del movimiento
            if (movimiento > 0)
                transform.localScale = new Vector3(1, 1, 1);
            else
                transform.localScale = new Vector3(-1, 1, 1);
        }
        else
        {
            // Si no hay movimiento, frenar el personaje
            rb.linearVelocity = new Vector2(0, rb.linearVelocity.y);
        }

        // Controlar animación
        anim.SetFloat("Velocidad", Mathf.Abs(movimiento));

        // Salto
        if (Input.GetKeyDown(KeyCode.Space) && enSuelo)
        {
            rb.AddForce(new Vector2(0, fuerzaSalto), ForceMode2D.Impulse);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Detectar cuando está en el suelo
        if (collision.gameObject.CompareTag("Suelo"))
        {
            enSuelo = true;
        }

        // Si choca con la pared, detener su movimiento en X
        if (collision.gameObject.CompareTag("Pared"))
        {
            rb.linearVelocity = new Vector2(0, rb.linearVelocity.y);
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        // Detectar cuando deja de tocar el suelo
        if (collision.gameObject.CompareTag("Suelo"))
        {
            enSuelo = false;
        }
    }
}
