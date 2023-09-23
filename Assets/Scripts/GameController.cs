using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class GameController : MonoBehaviour
{
    public int totalScore = 0;
    public static GameController instance;
    public TMP_Text vidaTexto;
    public TMP_Text melanciaTexto;
    public Canvas canvas;
    public int vidas = 3;
    public bool faseFinal = false;

    /// <summary>
    /// Não perder o controller ao resetar a tela
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
    /// Alterar os pontos do jogador
    /// </summary>
    /// <param name="ponto"></param>
    public void AlterarPontos(int ponto)
    {
        totalScore += ponto;
        RefreshScreen();
    }

    /// <summary>
    /// Atualizar a tela
    /// </summary>
    public void RefreshScreen()
    {
        vidaTexto.text = vidas.ToString();
        melanciaTexto.text = totalScore.ToString();
    }
}
