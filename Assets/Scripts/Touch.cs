using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch : MonoBehaviour
{
    public float speed;
    public GameObject player;
    float halfScreenWidth;

    private void Awake()
    {
        halfScreenWidth = Screen.width * 0.5f;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            UnityEngine.Touch touch = Input.touches[0];
            if (touch.position.x > halfScreenWidth)
            {
                Debug.Log("Left");
                player.transform.position=Vector3.Lerp(player.transform.position, player.transform.position + new Vector3(0,0,speed*Time.deltaTime),1);
            }
            else
            {
                Debug.Log("Right");
                player.transform.position=Vector3.Lerp(player.transform.position, player.transform.position + new Vector3(0, 0, -speed*Time.deltaTime), 1);
            }
        }
    }

}



