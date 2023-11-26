using Unity.VisualScripting;
using UnityEngine;

public class GroundTile : MonoBehaviour
{
    Ground_Spawner ground_Spawner;
    private void Start()
    {
        ground_Spawner = GameObject.FindObjectOfType<Ground_Spawner>();
        // SpawnObstacle();
    }

    private void OnTriggerExit(Collider other)
    {
        ground_Spawner.SpawnTile();
        Destroy(gameObject,2);
    }

    private void Update()
    {
        
    }

    public GameObject obstaclePrefab;

    void SpawnObstacle()
    {
        int obstacleSpawnIndex = Random.Range(2,8);
        Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform;

        Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
    }

}
