using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public static float speed;
    void Start()
    { 
    }

    // Update is called once per frame
    void Update()
    {
        if (Game.score <= 25)
        {
            speed = 10f;
        }
        else if (Game.score > 25 && Game.score <= 100)
        {
            speed = 13f;
        }
        else
        {
            speed = 15f;
        }
        Vector3 movement = new Vector3(-speed*Time.deltaTime, 0,0);

        transform.GetChild(0).GetComponent<Rigidbody>().AddForce(movement * speed);

       
    }


}
