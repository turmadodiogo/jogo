using UnityEngine;
using UnityEngine.SceneManagement;

namespace Menu
{
    public class MenuPrincipalManager : MonoBehaviour
    {
        [SerializeField] private string nomeDoLevelDeJogo;
        [SerializeField] private GameObject painelMenuInicial;
        [SerializeField] private GameObject painelOpcoes;
        public void Jogar()
        {
            SceneManager.LoadScene(nomeDoLevelDeJogo);
        }

        public void AbrirOpcoes()
        {
            painelMenuInicial.SetActive(false);
            painelOpcoes.SetActive(true);
        }

        public void FecharOpcoes()
        {
            painelOpcoes.SetActive(false);
            painelMenuInicial.SetActive(true);
        }

        public void SairJogo()
        {
            Debug.Log("Sair do jogo");
            Application.Quit();
        }
    }
}
