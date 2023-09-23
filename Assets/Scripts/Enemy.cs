using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float velocidade;
    private bool ground = true;
    public Transform groundCheck;
    public LayerMask groundLayer;
    private bool ladoDireito = true;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector2.right * velocidade * Time.deltaTime);
        ground = Physics2D.Linecast(groundCheck.position, transform.position, groundLayer);

        if (!ground)
        {
            velocidade *= -1;
        }

        if (velocidade > 0 && !ladoDireito)
        {
            Flip();
        }

        if (velocidade < 0 && ladoDireito)
        {
            Flip();
        }
    }

    /// <summary>
    /// Flip no inimigo para simular morte
    /// </summary>
    void Flip()
    {
        ladoDireito = !ladoDireito;
        Vector3 escala = transform.localScale;
        escala.x *= -1;
        transform.localScale = escala;
    }

    /// <summary>
    /// Colis�o para descontar vida do player
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<PersonagemScript>().DescontarVida();
        }
    }
}
