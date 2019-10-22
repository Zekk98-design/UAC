using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGen : MonoBehaviour
{
    public GameObject Generator;
    public GameObject GeneratorD;
    public GameObject DestroyPrompt;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (DestroyPrompt.activeInHierarchy == true && Input.GetKeyDown(KeyCode.E))
        {
            Generator.SetActive(false);
            GeneratorD.SetActive(true);
        }
    }
}
