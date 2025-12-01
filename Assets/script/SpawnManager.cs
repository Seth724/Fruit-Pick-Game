using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject[] fruitPrefabs;
    public Vector2 spawnRangeX;
    public float minSpawnPossition;
    public float maxSpawnPossition;
    public float startTime;
    public float repeatRate;

    public void Start()
    {
        InvokeRepeating("SpawnObject", startTime, repeatRate);
    }
    // Update is called once per frame
    private void SpawnObject(){
        float randomspawnRangeX = Random.Range(minSpawnPossition, maxSpawnPossition);
        int randomFruitIndex = Random.Range(0, fruitPrefabs.Length);
        GameObject fruit = fruitPrefabs[randomFruitIndex];
        Instantiate(fruit, new Vector2(randomspawnRangeX,spawnRangeX.y), Quaternion.identity);
    }
}
