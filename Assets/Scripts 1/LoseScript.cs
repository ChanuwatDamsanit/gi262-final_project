using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseScript : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadSceneAsync("StackQueue");
    }
    public void ReturnToMainMenu()
    {
        SceneManager.LoadSceneAsync("MainMenuScene");
    }
}
