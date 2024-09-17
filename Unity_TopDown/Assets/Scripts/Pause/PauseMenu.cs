using UnityEngine;
using UnityEngine.SceneManagement;

namespace Pause
{
    public class PauseMenu : MonoBehaviour
    {
        [SerializeField] private string menuSceneName;

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                LoadMenu();
            }
        }

        void LoadMenu()
        {
            SceneManager.LoadScene(menuSceneName);
        }
    }
}
