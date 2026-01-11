using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private GameManager gameManager;
    private AudioManager audioManager;
    void Awake()
    {
        gameManager = FindAnyObjectByType<GameManager>();
        audioManager = FindAnyObjectByType<AudioManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.CompareTag ("Coin"))
        {
            Destroy(collision.gameObject);
            audioManager.PlayCoinSound();
            gameManager.AddScore(1);
        }
        else if (collision.CompareTag ("Trap"))
        {
            gameManager.gameOver();
        }
        else if (collision.CompareTag ("Enemy"))
        {
            gameManager.gameOver();
        }
        else if (collision.CompareTag ("Key"))
        {
            Destroy(collision.gameObject);
            gameManager.GameWin();
        }
    }
}
 