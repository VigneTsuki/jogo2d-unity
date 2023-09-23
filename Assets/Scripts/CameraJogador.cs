using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform jogador;
    public float minimoX = 0.1f;
    public float maximoX = 20f;

    void FixedUpdate()
    {
        Vector3 posicao = jogador.position + new Vector3(0, 0, -10);
        posicao.y = 0.5f;
        transform.position = posicao;

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, minimoX, maximoX), transform.position.y, transform.position.z);
    }
}
