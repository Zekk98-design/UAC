using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OCGenerators : MonoBehaviour
{
    public GameObject GeneratorDestroyed1;
    public GameObject HiveWall1;
    public GameObject GeneratorDestroyed2;
    public GameObject HiveWall2;
    public GameObject GeneratorDestroyed3;
    public GameObject HiveWall3;
    public GameObject GeneratorDestroyed4;
    public GameObject HiveWall4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GeneratorDestroyed1.activeInHierarchy)
        {
            HiveWall1.SetActive(false);
        }
        if (GeneratorDestroyed2.activeInHierarchy)
        {
            HiveWall2.SetActive(false);
        }
        if (GeneratorDestroyed3.activeInHierarchy)
        {
            HiveWall3.SetActive(false);
        }
        if (GeneratorDestroyed4.activeInHierarchy)
        {
            HiveWall4.SetActive(false);
        }
    }
}
