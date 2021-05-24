using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemy;
    float randX;
    Vector2 whereToSpawn;
    public float spawnRate = 2f;
    float nextSpawn = 0.0f;
    public bool canSpawn = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn && canSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            randX = Random.Range(1, 100) > 50 ? 6 : -6;
            whereToSpawn = new Vector2(transform.position.x + randX, transform.position.y);
            Instantiate(enemy, whereToSpawn, Quaternion.identity);
            
        }
    }
}
