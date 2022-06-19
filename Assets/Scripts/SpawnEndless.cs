using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEndless : MonoBehaviour
{
    const float y = -1.115974f;
    const float z = -13.68731f;
    static float startX = -2576;
    public GameObject surface;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Da qua");
        GameObject surfaceNew = Instantiate(surface);
        surfaceNew.transform.position = new Vector3(startX, y, z);
        startX -= 2606.38f;
    }

  
}
