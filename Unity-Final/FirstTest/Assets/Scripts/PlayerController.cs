using NUnit.Framework;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float jumpForce = 15f;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private Transform groundCheck;
    private bool isGrounded;
    private Rigidbody2D rb;
    private Animator animator;
    private GameManager gameManager;

    private AudioManager audioManager; 
    private void Awake()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        gameManager = FindAnyObjectByType<GameManager>();
        audioManager = FindAnyObjectByType<AudioManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.IsGameOver() || gameManager.IsGameOver())
        {
            return;
        }
        HandleMovement();
        HandleJump();
        updateAnimation();
    }

    private void HandleMovement()
    {
        float moveX = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector2(moveX * moveSpeed, rb.linearVelocity.y);

        if (moveX > 0)
        {
            transform.localScale = new Vector3(1, 1, 1); //lật player lại nếu nhấn D thì mặt của player sẽ quay về bên phải
        }
        else if (moveX < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1); //lật player lại nếu nhấn A thì mặt của player sẽ quay về bên trái
        }
    }

    private void HandleJump() 
    {
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            audioManager.PlayJumpSound();
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce); //nhảy lên với lực nhảy là jumpForce
        }
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.1f, groundLayer);
    }

    private void updateAnimation()
    {
        bool isRunning = Mathf.Abs(rb.linearVelocity.x) > 0.1f;
        bool isJumping = !isGrounded;
        animator.SetBool("isRunning", isRunning);
        animator.SetBool("isJumping", isJumping);
    }
}
