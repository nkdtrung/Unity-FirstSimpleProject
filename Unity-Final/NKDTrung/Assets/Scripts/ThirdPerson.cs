using UnityEngine;

public class SimpleMouseOrbit : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float distance = 5.0f;
    [SerializeField] private float minDistance = 2.0f;
    [SerializeField] private float maxDistance = 12.0f;
    [SerializeField] private float height = 1.5f;
    [SerializeField] private float xSpeed = 300.0f;
    [SerializeField] private float ySpeed = 5.0f;
    [SerializeField] private float yMinLimit = -80f;
    [SerializeField] private float yMaxLimit = 80f;
    [SerializeField] private float zoomSpeed = 2.0f;

    private float x = 0.0f;
    private float y = 0.0f;

    void Start()
    {
        Vector3 angles = transform.eulerAngles;
        x = angles.y;
        y = angles.x;
    }

    void LateUpdate()
    {
        if (target == null) return;

        // Zoom bằng cuộn chuột
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        if (Mathf.Abs(scroll) > 0.01f)
        {
            distance -= scroll * zoomSpeed;
            distance = Mathf.Clamp(distance, minDistance, maxDistance);
        }

        if (Input.GetMouseButton(0))
        {
            x += Input.GetAxis("Mouse X") * xSpeed * Time.deltaTime;
            y -= Input.GetAxis("Mouse Y") * ySpeed * Time.deltaTime;
            y = Mathf.Clamp(y, yMinLimit, yMaxLimit);
        }

        Quaternion rotation = Quaternion.Euler(y, x, 0);
        Vector3 position = rotation * new Vector3(0.0f, height, -distance) + target.position;
        transform.rotation = rotation;
        transform.position = position;
    }
}