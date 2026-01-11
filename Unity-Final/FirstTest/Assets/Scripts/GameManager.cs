using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    private int score = 0;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private GameObject gameOverUi;
    [SerializeField] private GameObject gameWinUI;
    private bool isGameOver = false;
    private bool isGameWinUI = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateScore();
        gameOverUi.SetActive(false);
        gameWinUI.SetActive (false);
    }

    
    public void AddScore(int points)
    {
        if (!isGameOver && !isGameWinUI)
        {
            score += points;
            UpdateScore();
        }
    }
    
    private void UpdateScore()
    {
        scoreText.text = score.ToString();
    }

    public void gameOver()
    {
        if (!isGameOver)
        {
            isGameOver = true;
            gameOverUi.SetActive(true);
            Time.timeScale = 0f; // Pause the game
            score = 0;
        } 
    }

    public void GameWin()
    {
        if (!isGameWinUI)
        {
            isGameWinUI = true;
            gameWinUI.SetActive(true);
            Time.timeScale = 0f; // Pause the game
        }
    }

    public void RestartGame()
    {
        isGameOver = false;
        score = 0;
        UpdateScore();
        Time.timeScale = 1;
        SceneManager.LoadScene("Game");
    }

    public bool IsGameOver()
    {
        return isGameOver;
    }

    public bool IsGameWin()
    {
        return isGameWinUI;
    }

    public void gotoMenu()
    {
        Time.timeScale = 1f; // Resume the game time scale
        SceneManager.LoadScene("Menu");
    }
    
} 
