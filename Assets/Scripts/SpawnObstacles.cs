using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class SpawnObstacles : MonoBehaviour
{
    const float y = -2.685f;
    const float z = -13.85114f;
    float startX = 17.6645f;
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
        startX -= 8f;
    }

    void spawnObject()
    {
        GameObject obstacle = ObjectPool.instance.getGameObject();
        if (obstacle != null)
        {
            obstacle.transform.position = new Vector3(startX, y, z);
            obstacle.SetActive(true);
            Color color;
            for (int i=0; i<3; i++)
            {
                int c = Random.Range(0, 7);
                switch (c)
                {
                    case 0:
                        {
                            color = Color.green;
                            break;
                        }
                    case 1:
                        {
                            color = Color.yellow;
                            break;
                        }
                    case 2:
                        {
                            color = Color.blue;
                            break;
                        }
                    case 3:
                        {
                            color = Color.red;
                            break;
                        }
                    case 4:
                        {
                            color = Color.white;
                            break;
                        }
                    case 5:
                        {
                            color = Color.magenta;
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
            int randomNoOrYes = Random.Range(0, 2); //neu ra 1 thi se co mot o bi trong
            if (randomNoOrYes == 1)
            {
                int randomNo = Random.Range(0, 3);
                obstacle.transform.GetChild(randomNo).gameObject.SetActive(false);
                obstacle.transform.GetChild(randomNo).gameObject.GetComponent<BoxCollider>().enabled = false;
            }
            
        }
    }

 
}
