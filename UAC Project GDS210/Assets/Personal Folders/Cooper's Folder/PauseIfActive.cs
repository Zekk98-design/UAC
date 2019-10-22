using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseIfActive : MonoBehaviour
{
    public GameObject thing1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (thing1.activeInHierarchy)
        {
            Time.timeScale = 0f;
        }
        if (thing1.activeInHierarchy == false)
        {
            Time.timeScale = 1f;
        }
    }
}
