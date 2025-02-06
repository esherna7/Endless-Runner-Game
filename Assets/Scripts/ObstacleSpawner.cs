using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{

    public GameObject obstaclePrefrab;
    public float spawnInterval = 2f; // Time between Spawns
    public float spawnXPosition = 15f; // X position spawn
    public float spawnYPosition = 0.6f;  //  Y position spawn


    private float timer = 0f;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            SpawnObstacle();
            timer = 0f;
        }
    }

    void SpawnObstacle()
    {
        Vector2 spawnPosition = new(spawnXPosition, spawnYPosition); // Spawn at the right edge of the screen
        Instantiate(obstaclePrefrab, spawnPosition, Quaternion.identity);
    }
}
