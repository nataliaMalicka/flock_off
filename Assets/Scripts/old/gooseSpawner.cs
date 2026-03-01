using UnityEngine;

public class GooseSpawner : MonoBehaviour
{
    public GameObject goosePrefab;
    public Transform plane;
    public float spawnInterval = 2f;
    public float spawnDistance = 300f;
    public float spawnRadius = 20f;

    void Start()
    {
        InvokeRepeating("SpawnGoose", 1f, spawnInterval);
    }

    void SpawnGoose()
    {
        /*
        Vector3 spawnPos = new Vector3(
            plane.position.x + Random.Range(-spawnRadius, spawnRadius),
            plane.position.y + Random.Range(-5f, 10f),
            plane.position.z - spawnDistance
        );*/

        Vector3 spawnPos = new Vector3(
            plane.position.x,
            plane.position.y,
            plane.position.z - spawnDistance
        );

        GameObject goose = Instantiate(goosePrefab, spawnPos, Quaternion.identity);
        goose.GetComponent<goose>().target = plane;
    }
}