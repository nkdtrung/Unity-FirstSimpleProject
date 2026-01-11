using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    public void StartGame()
    {
        Time.timeScale = 1f; // Resume the game
        SceneManager.LoadScene("Game");
    }

    public void QuitGame()
    {
        Application.Quit();
    } 
}
