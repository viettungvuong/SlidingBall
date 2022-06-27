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
        if (Game.score <= 120)
        {
            speed = 7.5f;
        }
        else if (Game.score > 120 && Game.score <= 360)
        {
            speed = 8.5f;
        }
        else if (Game.score>300)
        {
            speed = 10.5f;
        }
        Vector3 movement = new Vector3(-speed*Time.deltaTime, 0, 0);
        transform.GetChild(0).GetComponent<Rigidbody>().AddForce(movement * speed);
        //transform.Translate(new Vector3(speed, 0, 0) * Time.deltaTime); //di chuyen player
    }


}
