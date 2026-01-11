using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMotor : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 4f;
    [SerializeField] private float jumpForce = 5f;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private float groundCheckRadius = 0.25f;
    [SerializeField] private LayerMask groundMask;

    private Rigidbody rb;
    private Animator anim;
    private bool isGrounded;
    private Vector3 inputDir;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();

        // Chặn xoay bởi va chạm
        rb.constraints = RigidbodyConstraints.FreezeRotationX |
                         RigidbodyConstraints.FreezeRotationY |
                         RigidbodyConstraints.FreezeRotationZ;
        rb.angularDamping = 6f;
        rb.interpolation = RigidbodyInterpolation.Interpolate;
        rb.collisionDetectionMode = CollisionDetectionMode.Continuous;
    }

    void Start()
    {
        // Đặt chân sát đất khi vào game
        if (Physics.Raycast(transform.position + Vector3.up, Vector3.down, out var hit, 5f, groundMask))
            transform.position = new Vector3(transform.position.x, hit.point.y + 0.01f, transform.position.z);
    }

    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        inputDir = new Vector3(h, 0, v);

        if (isGrounded && Input.GetButtonDown("Jump"))
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

    void FixedUpdate()
    {
        Vector3 camF = (Camera.main ? Camera.main.transform.forward : Vector3.forward); camF.y = 0;
        Vector3 camR = (Camera.main ? Camera.main.transform.right  : Vector3.right);   camR.y = 0;

        Vector3 moveDir = (camF.normalized * inputDir.z + camR.normalized * inputDir.x);

        // Chỉ xoay khi đi tới hoặc đi ngang; lùi không xoay
        if (moveDir.sqrMagnitude > 0.01f)
        {
            Vector3 flatDir = new Vector3(moveDir.x, 0, moveDir.z).normalized;
            Quaternion targetRot = Quaternion.LookRotation(flatDir);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRot, 540f * Time.fixedDeltaTime);
        }

        // Vận tốc ngang
        Vector3 vel = rb.linearVelocity;
        Vector3 horiz = moveDir.normalized * moveSpeed;

        // Nếu không có input → dừng trượt ngang
        if (inputDir.sqrMagnitude < 0.01f) { horiz = Vector3.zero; }

        vel.x = horiz.x;
        vel.z = horiz.z;
        rb.linearVelocity = vel;

        // Dập tắt xoay vật lý còn sót
        rb.angularVelocity = Vector3.zero;

        // Ground check
        if (groundCheck != null)
            isGrounded = Physics.CheckSphere(groundCheck.position, groundCheckRadius, groundMask);

        // Animator
        if (anim)
        {
            float speedValue = new Vector3(rb.linearVelocity.x, 0, rb.linearVelocity.z).magnitude;
            anim.SetFloat("Speed", speedValue);
        }
    }

    void OnDrawGizmosSelected()
    {
        if (groundCheck)
        {
            Gizmos.color = Color.yellow;
            Gizmos.DrawWireSphere(groundCheck.position, groundCheckRadius);
        }
    }
}