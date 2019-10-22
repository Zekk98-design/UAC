using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ICGenerators : MonoBehaviour
{

    public GameObject Generator1D;
    public GameObject Generator2D;
    public GameObject Generator3D;
    public GameObject Generator4D;
    public GameObject Forcefield;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Generator1D.activeInHierarchy && Generator2D.activeInHierarchy && Generator3D.activeInHierarchy && Generator4D.activeInHierarchy)
        {
            Forcefield.SetActive(false);
        }
    }

}
