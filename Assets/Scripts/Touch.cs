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
                player.transform.position = new Vector3(
                    player.transform.position.x,
                    player.transform.position.y,
                    player.transform.position.z + touch.deltaPosition.y * speed
                    ) ;
            }
        }

    }


}
