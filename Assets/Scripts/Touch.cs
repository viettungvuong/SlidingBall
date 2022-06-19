using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch : MonoBehaviour
{
    public GameObject player;
    float screenCenterX;
    public float speed;
    void Start()
    {
        screenCenterX = Screen.width * 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            //lan dau bam
            UnityEngine.Touch touch = Input.GetTouch(0);

            
            if (touch.phase == TouchPhase.Moved) //dung de drag
            {
                Vector3 touchedPos = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, 10));
                // lerp and set the position of the current object to that of the touch, but smoothly over time.
                player.transform.position = Vector3.Lerp(player.transform.position, touchedPos, Time.deltaTime);
            }
        }

    }


}
