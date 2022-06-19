using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;
    void Start()
    { 
    }

    // Update is called once per frame
    void Update()
    {
        if (Game.score <= 25)
        {
            speed = 4f;
        }
        else if (Game.score > 25 && Game.score <= 100)
        {
            speed = 5f;
        }
        else
        {
            speed = 6f;
        }
        transform.Translate(new Vector3(-speed, 0, 0) * Time.deltaTime); //di chuyen player
    }


}
