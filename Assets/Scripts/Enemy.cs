using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public float velocidade;
    private bool ground = true;
    public Transform groundCheck;
    public LayerMask groundLayer;
    private bool ladoDireito = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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

    void Flip()
    {
        ladoDireito = !ladoDireito;
        Vector3 escala = transform.localScale;
        escala.x *= -1;
        transform.localScale = escala;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
