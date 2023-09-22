using UnityEngine;

public class PersonagemScript : MonoBehaviour
{
    public float velocidade;
    public float forcaPulo;
    private Rigidbody2D rb;
    private Animator anim;
    private bool isJumping;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Movimentacao();
        Pulo();
    }

    void Movimentacao()
    {
        Vector3 movimento = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movimento * Time.deltaTime * velocidade;

        if (Input.GetAxis("Horizontal") > 0f)
        {
            anim.SetBool("walk", true);
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }

        if (Input.GetAxis("Horizontal") < 0f)
        {
            anim.SetBool("walk", true);
            transform.eulerAngles = new Vector3(0f, 180f, 0f);
        }

        if (Input.GetAxis("Horizontal") == 0f)
        {
            anim.SetBool("walk", false);
        }
    }

    void Pulo()
    {
        if (Input.GetButtonDown("Jump") && !isJumping)
        {
            rb.AddForce(new Vector2(0f, forcaPulo), ForceMode2D.Impulse);
            anim.SetBool("jump", true);
            isJumping = true;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 8)
        {
            isJumping = false;
        }

        anim.SetBool("jump", false);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            isJumping = true;
        }
    }
}
