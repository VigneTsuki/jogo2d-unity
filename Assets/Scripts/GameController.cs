using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public int totalScore;

    public static GameController instance;
    public TMP_Text vidaTexto;
    public int vidas = 3;

    /// <summary>
    /// Não perder o controller ao resetar a tela
    /// </summary>
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(transform.root);
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
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

    void Update()
    {
    }
}
