using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseBtn : MonoBehaviour
{
    public static bool paused = false;
    Vector3 originalSize;
    void Start()
    {
        originalSize = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void pauseGame()
    {
        Debug.Log("Da bam");
        if (!paused)
        {
            Time.timeScale = 0;
            paused = true;
            transform.localScale = originalSize * 0.9f;
        }
        else
        {
            Time.timeScale = 1;
            paused = false;
            transform.localScale = originalSize;
        }
    }
}
