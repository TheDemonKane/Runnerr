using UnityEngine;

public class Ground_Spawner : MonoBehaviour
{

    public GameObject[] groundTiles;
    Vector3 nextSpawnPoint;

    

    public void SpawnTile()
    {
        int RandomOption = Random.Range(0, groundTiles.Length);
        GameObject temp = Instantiate(groundTiles[RandomOption], nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;
    }

    private void Start()
    {
        for(int i=0; i<15; i++)
        {
            SpawnTile();
        }
    }

}
