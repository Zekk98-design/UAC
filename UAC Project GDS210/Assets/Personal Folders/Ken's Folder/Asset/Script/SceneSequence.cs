using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneSequence : MonoBehaviour
{
    //Variables
    public GameObject Cam1;
    public GameObject Cam2;
    public GameObject Cam3;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TheSequence());
    }

    IEnumerator TheSequence()
    {
        yield return new WaitForSeconds(2);
        Cam2.SetActive(true);
        Cam1.SetActive(false);
        yield return new WaitForSeconds(2);
        Cam3.SetActive(true);
        Cam2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
