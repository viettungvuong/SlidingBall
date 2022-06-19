using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public static int score=0;
    public GameObject player;
    void Start()
    {
        Color color;
        int c = Random.Range(0, 3);
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
        player.gameObject.GetComponent<Renderer>().material.color = color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
