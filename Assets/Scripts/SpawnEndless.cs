using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEndless : MonoBehaviour
{
    public GameObject surface;
    Vector3 spawnPos;
    private void Awake()
    {
    }
    void Start()
    {
        spawnPos = transform.parent.lossyScale; //lay diem cuoi
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
            GameObject obstacle = Instantiate(surface);
            obstacle.transform.position = new Vector3(spawnPos.x,transform.parent.position.y,transform.parent.position.z) ;
            obstacle.SetActive(true);
    }
}
