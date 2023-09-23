using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public int totalScore;

    public static GameController instance;
    public TMP_Text vidaTexto;
    public int vidas = 3;

    /// <summary>
    /// N�o perder o controller ao resetar a tela
    /// </summary>
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    /// <summary>
    /// Alterar a vida do jogador
    /// </summary>
    /// <param name="vida"></param>
    public void AlterarVida(int vida)
    {
        vidas += vida;
        if(vidas >= 0)
            RefreshScreen();
    }

    /// <summary>
    /// Atualizar a tela
    /// </summary>
    public void RefreshScreen()
    {
        vidaTexto.text = vidas.ToString();
    }
}
