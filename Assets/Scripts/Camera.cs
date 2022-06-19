using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform target;
    private Vector3 offset;
    public float speed;
    void Start()
    {
        offset = transform.position - target.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 goTo = new Vector3(offset.x + target.position.x, transform.position.y, offset.z+target.position.z);
        transform.position = Vector3.Lerp(transform.position, goTo, speed);
    }
}
