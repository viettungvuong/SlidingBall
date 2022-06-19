using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class SpawnObstacles : MonoBehaviour
{
    const float y = -2.604645f;
    const float z = -13.85114f;
    float startX = 27.6645f;
    public GameObject player;
    
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
            bool[] used = { false, false, false };
            Color color;
            for (int i=0; i<3; i++)
            {
                int c;
                do
                {
                    c = Random.Range(0, 3);
                } while (used[c]);
                used[c] = true;
                switch (c)
                {
                    case 0:
                        {
                            color = Color.green;
                            break;
                        }
                    case 1:
                        {
                            color = Color.red;
                            break;
                        }
                    default:
                        {
                            color = Color.cyan;
                            break;
                        }
                }
                obstacle.transform.GetChild(i).GetComponent<Renderer>().material.color = color;
            }
           
        }
    }

 
}
