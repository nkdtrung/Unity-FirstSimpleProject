using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 3f;
    [SerializeField] private float distance = 5f;  
    private Vector3 startPos;
    private bool movingRight = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float leftBound = startPos.x - distance;
        float rightBound = startPos.x + distance;
        if (movingRight)
        {
            transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
            if (transform.position.x >= rightBound)
            {
                movingRight = false;
                transform.localScale = new Vector3(-1, 1, 1); // Flip the enemy to face left
            }
        }
        else
        {
            transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
            if (transform.position.x <= leftBound)
            {
                movingRight = true;
                transform.localScale = new Vector3(1, 1, 1); // Flip the enemy to face right
            }
        }
    }
}
