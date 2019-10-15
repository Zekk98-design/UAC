using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathCollider : MonoBehaviour
{
    public GameObject DeathMenu;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }


    // Update is called once per frame
    void Update()
    {
        if (DeathMenu == true)
        {
            Time.timeScale = 0f;
        }
        if (DeathMenu == true && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); // loads current scene
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        DeathMenu.SetActive(true);
        Cursor.visible = true;
    }


}
