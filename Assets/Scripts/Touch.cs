using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Touch : MonoBehaviour
{
    public float speed;
    public GameObject player;
    Vector3 startPos;
    private Vector2 fingerDown;
    private Vector2 fingerUp;
    public bool detectSwipeOnlyAfterRelease = false;

    public float SWIPE_THRESHOLD = 20f;


    bool swiped = false;


    // Update is called once per frame
    void Update()
    {

        foreach (UnityEngine.Touch touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Began)
            {
                fingerUp = touch.position;
                fingerDown = touch.position;
            }

            //Detects Swipe while finger is still moving
            if (touch.phase == TouchPhase.Moved)
            {
                if (!detectSwipeOnlyAfterRelease)
                {
                    fingerDown = touch.position;
                    checkSwipe();
                }
            }

            //Detects swipe after finger is released
            if (touch.phase == TouchPhase.Ended)
            {
                fingerDown = touch.position;
                checkSwipe();
            }
        }
    }

    void checkSwipe()
    {
        //Check if Vertical swipe
        if (verticalMove() > SWIPE_THRESHOLD && verticalMove() > horizontalValMove())
        {
            //Debug.Log("Vertical");
            if (fingerDown.y - fingerUp.y > 0)//up swipe
            {
                OnSwipeUp();
            }
            else if (fingerDown.y - fingerUp.y < 0)//Down swipe
            {
                OnSwipeDown();
            }
            fingerUp = fingerDown;
        }

        //Check if Horizontal swipe
        else if (horizontalValMove() > SWIPE_THRESHOLD && horizontalValMove() > verticalMove())
        {
            //Debug.Log("Horizontal");
            if (fingerDown.x - fingerUp.x > 0)//Right swipe
            {
                OnSwipeRight();
            }
            else if (fingerDown.x - fingerUp.x < 0)//Left swipe
            {
                OnSwipeLeft();
            }
            fingerUp = fingerDown;
        }

        //No Movement at-all
        else
        {
            //Debug.Log("No Swipe!");
        }
    }

    float verticalMove()
    {
        return Mathf.Abs(fingerDown.y - fingerUp.y);
    }

    float horizontalValMove()
    {
        return Mathf.Abs(fingerDown.x - fingerUp.x);
    }


    void OnSwipeUp()
    {
        Debug.Log("Swipe UP");
        Jump();
    }

    void OnSwipeDown()
    {
        Debug.Log("Swipe Down");
    }

    void OnSwipeLeft()
    {
        Debug.Log("Swipe Left");
        Left();
    }

    void OnSwipeRight()
    {
        Debug.Log("Swipe Right");
        Right();
    }


    void Jump()
    {
        Debug.Log("Jump");
        player.transform.GetComponent<Rigidbody>().velocity = transform.TransformDirection(new Vector3(0, 3.5f, 0)); //nhay len
    }


    void Right()
    {

        Debug.Log("Right");
        player.transform.position = Vector3.Lerp(player.transform.position, player.transform.position + new Vector3(0, 0, speed * Time.deltaTime), 1);
        //player.transform.GetComponent<Rigidbody>().velocity = transform.TransformDirection(new Vector3(0, 6, speed*Time.deltaTime)); //qua trai
    }

    void Left()
    {

        Debug.Log("Left");
        player.transform.position=Vector3.Lerp(player.transform.position, player.transform.position + new Vector3(0, 0, -speed*Time.deltaTime), 1);
        //player.transform.GetComponent<Rigidbody>().velocity = transform.TransformDirection(new Vector3(0, 6, -speed * Time.deltaTime)); //nhay len

    }
   
 

}



