using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ExitOnClick : MonoBehaviour
{
    public Button ExitButton;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = ExitButton.GetComponent<Button>();
    }

    // Update is called once per frame

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Application.Quit();
        }        
    }   
}
