using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReplayBtn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void replay()
    {
        Debug.Log("Da bam");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
