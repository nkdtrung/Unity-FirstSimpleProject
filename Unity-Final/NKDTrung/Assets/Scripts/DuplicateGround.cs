using UnityEngine;

public class GroundModelGrid : MonoBehaviour
{
    [SerializeField] private GameObject groundPrefab; // Kéo model Ground (obj đã gán material) vào đây
    [SerializeField] private int gridX = 5;
    [SerializeField] private int gridZ = 5;
    [SerializeField] private float spacingX = 5f; // Khoảng cách giữa các model theo X
    [SerializeField] private float spacingZ = 5f; // Khoảng cách giữa các model theo Z

    void Start()
    {
        for (int x = 0; x < gridX; x++)
        {
            for (int z = 0; z < gridZ; z++)
            {
                Vector3 pos = new Vector3(x * spacingX, -0.1f, z * spacingZ);
                Instantiate(groundPrefab, pos, Quaternion.identity, transform);
            }
        }
    }
}