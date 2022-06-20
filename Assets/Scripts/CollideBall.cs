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
            if (collision.gameObject.GetComponent<Renderer>().material.GetColor("Color_d3f90b46fa4040c48d4031973961bef6") == GetComponent<Renderer>().material.color)
            {
                this.gameObject.GetComponent<Collider>().enabled = false;
                this.gameObject.SetActive(false);
                Color color;
                int c = Random.Range(0, 7);
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
                    case 2:
                        {
                            color = Color.black;
                            break;
                        }
                    case 3:
                        {
                            color = Color.red;
                            break;
                        }
                    case 4:
                        {
                            color = Color.white;
                            break;
                        }
                    case 5:
                        {
                            color = Color.magenta;
                            break;
                        }
                    default:
                        {
                            color = Color.cyan;
                            break;
                        }
                }
                hit = true;
                collision.gameObject.GetComponent<Renderer>().material.SetColor("Color_d3f90b46fa4040c48d4031973961bef6", color);
                collision.gameObject.GetComponent<Renderer>().material.SetColor("Color_64d861fce71044349695d1bac7f2ea98", color * 0.5f);

                hit = false; //chan truong hop dung trung ma kh qua dc do dinh ti cua ben kia

            }
            else
            {
                if (!hit)
                    Game.instance.Lose();
            }
        }
    }
}
