using UnityEngine;
using System.Collections.Generic;

public class ChunkManager : MonoBehaviour
{
    [SerializeField] private GameObject groundPrefab;
    [SerializeField] private int chunkSize = 16;
    [SerializeField] private int chunkViewDistance = 3;
    [SerializeField] private Transform player;

    private Dictionary<Vector2Int, GameObject> chunks = new Dictionary<Vector2Int, GameObject>();

    void Update()
    {
        Vector2Int playerChunk = new Vector2Int(
            Mathf.FloorToInt(player.position.x / chunkSize),
            Mathf.FloorToInt(player.position.z / chunkSize)
        );

        // Hiện các chunk gần player, ẩn các chunk xa
        for (int x = -chunkViewDistance; x <= chunkViewDistance; x++)
        {
            for (int z = -chunkViewDistance; z <= chunkViewDistance; z++)
            {
                Vector2Int chunkCoord = playerChunk + new Vector2Int(x, z);
                if (!chunks.ContainsKey(chunkCoord))
                {
                    Vector3 chunkPos = new Vector3(chunkCoord.x * chunkSize, 0, chunkCoord.y * chunkSize);
                    GameObject chunk = Instantiate(groundPrefab, chunkPos, Quaternion.identity, transform);
                    chunk.name = $"Chunk_{chunkCoord.x}_{chunkCoord.y}";
                    chunks.Add(chunkCoord, chunk);
                }
                else
                {
                    chunks[chunkCoord].SetActive(true);
                }
            }
        }

        // Ẩn các chunk xa player
        foreach (var kvp in chunks)
        {
            if (Mathf.Abs(kvp.Key.x - playerChunk.x) > chunkViewDistance ||
                Mathf.Abs(kvp.Key.y - playerChunk.y) > chunkViewDistance)
            {
                kvp.Value.SetActive(false);
            }
        }
    }
}