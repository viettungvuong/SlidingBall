using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideBall : MonoBehaviour
{
    // Start is called before the first frame update
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
                            color = Color.red;
                            break;
                        }
                    default:
                        {
                            color = Color.cyan;
                            break;
                        }
                }
                collision.gameObject.GetComponent<Renderer>().material.color = color;
                this.gameObject.SetActive(false);
            }
            else
               Time.timeScale = 0;
        }
    }
}
