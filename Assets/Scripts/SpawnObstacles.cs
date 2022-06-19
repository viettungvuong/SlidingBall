using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class SpawnObstacles : MonoBehaviour
{
    const float left = -14.69f;
    const float right = -12.99f;
    const float y = -2.16f;
    float startX = 15.6645f;
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
        startX -= 10f;
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
        return Random.Range(left,right);
    }
 
}
