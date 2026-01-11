using UnityEngine;

public class GroundGridGenerator : MonoBehaviour
{
    [SerializeField] private GameObject groundPrefab; // Kéo Plane hoặc Cube vào đây
    [SerializeField] private int gridX = 1000;
    [SerializeField] private int gridZ = 1000;
    [SerializeField] private float spacing = 5f; // Khoảng cách giữa các mặt đất

    void Start()
    {
        for (int x = 0; x < gridX; x++)
        {
            for (int z = 0; z < gridZ; z++)
            {
                Vector3 pos = new Vector3(x * spacing, 0, z * spacing);
                GameObject ground = Instantiate(groundPrefab, pos, Quaternion.identity, transform);
            }
        }
    }
}