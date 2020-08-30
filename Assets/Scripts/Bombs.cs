using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bombs : MonoBehaviour
{
    public GameObject enemy;
    float randX;
    Vector2 whereToSpawn;
    public float spawnRate = 2f;
    float nextSpawn = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
 
    }

    void Update()
    {
        nextSpawn = Time.time + spawnRate;
        randX = Random.Range(-0.4f, 0.4f);
        whereToSpawn = new Vector2(randX, transform.position.y);
        Instantiate(enemy, whereToSpawn, Quaternion.identity);
    }
}
