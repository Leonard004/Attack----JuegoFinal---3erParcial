using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpwaner : MonoBehaviour
{
    private float secondsLeftTillSpawn = 0;

    public float spawnSpeed = 0;
    public float spawnChance;

    public GameObject obstPrefab;

    public Player p;

    void Update()
    {
        if (p.isPlaying)
        {
            secondsLeftTillSpawn -= Time.deltaTime;
            int temp = Random.Range(0, 100);

            if (temp <= spawnChance && secondsLeftTillSpawn <= 0)
            {
                Instantiate(obstPrefab, new Vector3(12.5f, Random.Range(transform.position.y + 3.9f, transform.position.y - 3.9f), 0), Quaternion.identity, transform);

                secondsLeftTillSpawn = spawnSpeed;
            }
        }
        else if (transform.childCount > 0)
        {
            foreach (Transform t in transform)
            {
                Destroy(t.gameObject);
            }
        }
    }
}
