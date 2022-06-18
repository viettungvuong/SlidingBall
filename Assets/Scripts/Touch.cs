using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch : MonoBehaviour
{
    public GameObject player;
    float screenCenterX;
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
            UnityEngine.Touch firstTouch = Input.GetTouch(0);

            
            if (firstTouch.phase == TouchPhase.Began)
            {
                if (firstTouch.position.x > screenCenterX)
                {
                    // ben phai
                    player.transform.Translate(0, 0, -0.5f);
                }
                else if (firstTouch.position.x < screenCenterX)
                {
                    // ben trai
                    player.transform.Translate(0, 0, 0.5f);
                }
            }
        }

    }


}
