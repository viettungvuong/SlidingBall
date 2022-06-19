using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideBall : MonoBehaviour
{
    static bool hit = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (collision.gameObject.GetComponent<Renderer>().material.color == GetComponent<Renderer>().material.color)
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
                            color = Color.yellow;
                            break;
                        }
                    default:
                        {
                            color = Color.cyan;
                            break;
                        }
                }
                hit = true;
                collision.gameObject.GetComponent<Renderer>().material.color = color;     
                this.gameObject.SetActive(false);
                Game.score++;
                hit = false; //chan truong hop dung trung ma kh qua dc do dinh ti cua ben kia
            }
            else
            {
                if (!hit)
                    Time.timeScale = 0;
            }
        }
    }
}
