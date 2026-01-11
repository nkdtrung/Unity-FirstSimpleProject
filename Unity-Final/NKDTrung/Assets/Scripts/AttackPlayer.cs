using UnityEngine;

public class EnemyChase : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float detectRange = 8f;
    [SerializeField] private float moveSpeed = 2f;

    void Update()
    {
        if (player == null) return;

        float distance = Vector3.Distance(transform.position, player.position);
        if (distance <= detectRange)
        {
            // Di chuyển về phía Player
            Vector3 direction = (player.position - transform.position).normalized;
            transform.position += direction * moveSpeed * Time.deltaTime;

            // Xoay hướng về Player
            Quaternion lookRot = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRot, 10f * Time.deltaTime);
        }
    }
}