using UnityEngine;

public class Fruta : MonoBehaviour
{
    public int Score;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    /// <summary>
    /// Colisão para somar score do jogador
    /// </summary>
    /// <param name="collision"></param>
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player") 
        {
            GameController.instance.totalScore += Score;
            Destroy(gameObject);
        }
    }
}
