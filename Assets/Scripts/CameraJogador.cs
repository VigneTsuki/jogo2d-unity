using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform jogador;
    public float minimoX = 0.1f;
    public float maximoX = 20f;

    void FixedUpdate()
    {
        // posi��o z -10 para a cam�ra n�o ficar sobreposta com a camada do jogo em si
        Vector3 posicao = jogador.position + new Vector3(0, 0, -10);
        
        // 0.5 para evitar cortar o in�cio dos blocos do asset
        posicao.y = 0.5f;
        transform.position = posicao;

        // Limitar a posi��o x da c�mera
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, minimoX, maximoX), transform.position.y, transform.position.z);
    }
}
