using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject PauseParent;
    public GameObject DeathMenu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseParent.SetActive(true);
        }
        if (PauseParent.activeInHierarchy)
        {
            Time.timeScale = 0f;
        }
        if (PauseParent.activeInHierarchy == false && DeathMenu.activeInHierarchy == false)
        {
            Time.timeScale = 1f;
        }
    }
}
