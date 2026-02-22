using UnityEngine;
using System.Collections.Generic;

public class PickupSpawner : MonoBehaviour
{
    [SerializeField] private GameObject coinPrefab;
    [SerializeField] private GameObject healthPrefab;
    [SerializeField] private GameObject poisonPrefab;
    [SerializeField] private Transform[] platforms;

    void Start()
    {
        SpawnPickupsOnce();
    }

    void SpawnPickupsOnce()
    {
        List<int> availablePlatforms = new List<int>();
        for (int i = 0; i < platforms.Length; i++)
        {
            availablePlatforms.Add(i);
        }

        GameObject[] pickups = { coinPrefab, healthPrefab, poisonPrefab };
        int spawnCount = Mathf.Min(platforms.Length, pickups.Length);

        for (int i = 0; i < spawnCount; i++)
        {
            if (availablePlatforms.Count == 0)
                break;

            int randomIndex = Random.Range(0, availablePlatforms.Count);
            int platformIndex = availablePlatforms[randomIndex];

            Transform platform = platforms[platformIndex];
            Vector3 spawnPos = platform.position + Vector3.up * 1f;
            Instantiate(pickups[i], spawnPos, Quaternion.identity);
            availablePlatforms.RemoveAt(randomIndex);
        }
    }
}