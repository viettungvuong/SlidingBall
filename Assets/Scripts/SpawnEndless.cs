using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEndless : MonoBehaviour
{
    const float y = -2.63f;
    const float z = -13.71f;
    public GameObject surface;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Da qua");
        GameObject surfaceNew = Instantiate(surface);
        surfaceNew.transform.position = new Vector3(transform.parent.position.x + transform.lossyScale.x, y, z);
    }

  
}
