using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeginGame : MonoBehaviour
{
    public GameObject Player;
    public GameObject Cutscene;
    public GameObject MainMenu;
    public GameObject MainMenuCam;
    public float delay;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
        }
    }

    public void SwitchCam()
    {
        Cutscene.SetActive(true);
        MainMenu.SetActive(false);
        MainMenuCam.SetActive(false);
        Invoke("ActivePlayer", delay);
    }

    public void ActivePlayer()
    {
        Player.SetActive(true);
        Cutscene.SetActive(false);
    }
}
