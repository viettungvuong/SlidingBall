using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class SpawnObstacles : MonoBehaviour
{
    const float y = 0.47f;
    float startX = 24.41f;
    float z;
    private void Awake()
    {

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnObject();
        startX += 10f;
    }

    void spawnObject()
    {
        GameObject obstacle = ObjectPool.instance.getGameObject();
        if (obstacle != null)
        {
            obstacle.transform.position = new Vector3(startX, y, getZ());
            obstacle.SetActive(true);
        }
    }

    float getZ() //tim vi tri ngang
    {
        return Random.Range(-11.15f, -3.03f);
    }
 
}
