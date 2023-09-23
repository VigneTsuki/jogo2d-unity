using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void CarregarTela(string cena)
    {
        SceneManager.LoadScene(cena);
    }

    public void Sair()
    {
        Application.Quit();
    }
}
