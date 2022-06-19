using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class SpawnObstacles : MonoBehaviour
{
    const float y = -2.604645f;
    const float z = -13.85114f;
    float startX = 27.6645f;
    
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
            obstacle.transform.position = new Vector3(startX, y, z);
            obstacle.SetActive(true);
        }
    }

 
}
