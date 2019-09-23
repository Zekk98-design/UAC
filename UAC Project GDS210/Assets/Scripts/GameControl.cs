using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    // Game control:
    // Controls Player Health UI, Player potion count.

    public GameObject questLog;
    public GameObject bar1, bar2, bar3, bar4, bar5, bar6;
    public GameObject iBar1, iBar2, iBar3, iBar4, iBar5, iBar6, iBar7, iBar8, iBar9, iBar10, iBar11;

    public static int health;
    public static int potionCount;

    // Start is called before the first frame update
    void Start()
    {
        health = 6;
        bar1.gameObject.SetActive(true);
        bar2.gameObject.SetActive(true);
        bar3.gameObject.SetActive(true);
        bar4.gameObject.SetActive(true);
        bar5.gameObject.SetActive(true);
        bar6.gameObject.SetActive(true);

        potionCount = 0;
        iBar1.gameObject.SetActive(true);
        iBar2.gameObject.SetActive(false);
        iBar3.gameObject.SetActive(false);
        iBar4.gameObject.SetActive(false);
        iBar5.gameObject.SetActive(false);
        iBar6.gameObject.SetActive(false);
        iBar7.gameObject.SetActive(false);
        iBar8.gameObject.SetActive(false);
        iBar9.gameObject.SetActive(false);
        iBar10.gameObject.SetActive(false);
        iBar11.gameObject.SetActive(false);

        questLog.gameObject.SetActive (false);
    }

    // Update is called once per frame
    void Update()
    {   
        // Player quest / mission log toggle.
        if (Input.GetKeyDown("q"))
        {
            questLog.gameObject.SetActive (true);
        }
        if (Input.GetKeyDown("c"))
        {
            questLog.gameObject.SetActive (false);
        }

        // Player health bar.
        if (health > 6)
            health = 6;
            {
                switch (health)
                {
                    case 6:
                    bar1.gameObject.SetActive(true);
                    bar2.gameObject.SetActive(true);
                    bar3.gameObject.SetActive(true);
                    bar4.gameObject.SetActive(true);
                    bar5.gameObject.SetActive(true);
                    bar6.gameObject.SetActive(true);
                    break;
                    case 5:
                    bar1.gameObject.SetActive(true);
                    bar2.gameObject.SetActive(true);
                    bar3.gameObject.SetActive(true);
                    bar4.gameObject.SetActive(true);
                    bar5.gameObject.SetActive(true);
                    bar6.gameObject.SetActive(false);
                    break;
                    case 4:
                    bar1.gameObject.SetActive(true);
                    bar2.gameObject.SetActive(true);
                    bar3.gameObject.SetActive(true);
                    bar4.gameObject.SetActive(true);
                    bar5.gameObject.SetActive(false);
                    bar6.gameObject.SetActive(false);
                    break;
                    case 3:
                    bar1.gameObject.SetActive(true);
                    bar2.gameObject.SetActive(true);
                    bar3.gameObject.SetActive(true);
                    bar4.gameObject.SetActive(false);
                    bar5.gameObject.SetActive(false);
                    bar6.gameObject.SetActive(false);
                    break;
                    case 2:
                    bar1.gameObject.SetActive(true);
                    bar2.gameObject.SetActive(true);
                    bar3.gameObject.SetActive(false);
                    bar4.gameObject.SetActive(false);
                    bar5.gameObject.SetActive(false);
                    bar6.gameObject.SetActive(false);
                    break;
                    case 1:
                    bar1.gameObject.SetActive(true);
                    bar2.gameObject.SetActive(false);
                    bar3.gameObject.SetActive(false);
                    bar4.gameObject.SetActive(false);
                    bar5.gameObject.SetActive(false);
                    bar6.gameObject.SetActive(false);
                    break;
                    case 0:
                    bar1.gameObject.SetActive(false);
                    bar2.gameObject.SetActive(false);
                    bar3.gameObject.SetActive(false);
                    bar4.gameObject.SetActive(false);
                    bar5.gameObject.SetActive(false);
                    bar6.gameObject.SetActive(false);
                    break;
                }
            }
        
        if (potionCount < 0)
            potionCount = 0;
            {
                switch (potionCount)
                {
                    case 0:
                    iBar1.gameObject.SetActive(true);
                    iBar2.gameObject.SetActive(false);
                    iBar3.gameObject.SetActive(false);
                    iBar4.gameObject.SetActive(false);
                    iBar5.gameObject.SetActive(false);
                    iBar6.gameObject.SetActive(false);
                    iBar7.gameObject.SetActive(false);
                    iBar8.gameObject.SetActive(false);
                    iBar9.gameObject.SetActive(false);
                    iBar10.gameObject.SetActive(false);
                    iBar11.gameObject.SetActive(false);
                    break;
                    case 1:
                    iBar1.gameObject.SetActive(false);
                    iBar2.gameObject.SetActive(true);
                    iBar3.gameObject.SetActive(false);
                    iBar4.gameObject.SetActive(false);
                    iBar5.gameObject.SetActive(false);
                    iBar6.gameObject.SetActive(false);
                    iBar7.gameObject.SetActive(false);
                    iBar8.gameObject.SetActive(false);
                    iBar9.gameObject.SetActive(false);
                    iBar10.gameObject.SetActive(false);
                    iBar11.gameObject.SetActive(false);
                    break;
                    case 2:
                    iBar1.gameObject.SetActive(false);
                    iBar2.gameObject.SetActive(false);
                    iBar3.gameObject.SetActive(true);
                    iBar4.gameObject.SetActive(false);
                    iBar5.gameObject.SetActive(false);
                    iBar6.gameObject.SetActive(false);
                    iBar7.gameObject.SetActive(false);
                    iBar8.gameObject.SetActive(false);
                    iBar9.gameObject.SetActive(false);
                    iBar10.gameObject.SetActive(false);
                    iBar11.gameObject.SetActive(false);
                    break;
                    case 3:
                    iBar1.gameObject.SetActive(false);
                    iBar2.gameObject.SetActive(false);
                    iBar3.gameObject.SetActive(false);
                    iBar4.gameObject.SetActive(true);
                    iBar5.gameObject.SetActive(false);
                    iBar6.gameObject.SetActive(false);
                    iBar7.gameObject.SetActive(false);
                    iBar8.gameObject.SetActive(false);
                    iBar9.gameObject.SetActive(false);
                    iBar10.gameObject.SetActive(false);
                    iBar11.gameObject.SetActive(false);
                    break;
                    case 4:
                    iBar1.gameObject.SetActive(false);
                    iBar2.gameObject.SetActive(false);
                    iBar3.gameObject.SetActive(false);
                    iBar4.gameObject.SetActive(false);
                    iBar5.gameObject.SetActive(true);
                    iBar6.gameObject.SetActive(false);
                    iBar7.gameObject.SetActive(false);
                    iBar8.gameObject.SetActive(false);
                    iBar9.gameObject.SetActive(false);
                    iBar10.gameObject.SetActive(false);
                    iBar11.gameObject.SetActive(false);
                    break;
                    case 5:
                    iBar1.gameObject.SetActive(false);
                    iBar2.gameObject.SetActive(false);
                    iBar3.gameObject.SetActive(false);
                    iBar4.gameObject.SetActive(false);
                    iBar5.gameObject.SetActive(false);
                    iBar6.gameObject.SetActive(true);
                    iBar7.gameObject.SetActive(false);
                    iBar8.gameObject.SetActive(false);
                    iBar9.gameObject.SetActive(false);
                    iBar10.gameObject.SetActive(false);
                    iBar11.gameObject.SetActive(false);
                    break;
                    case 6:
                    iBar1.gameObject.SetActive(false);
                    iBar2.gameObject.SetActive(false);
                    iBar3.gameObject.SetActive(false);
                    iBar4.gameObject.SetActive(false);
                    iBar5.gameObject.SetActive(false);
                    iBar6.gameObject.SetActive(false);
                    iBar7.gameObject.SetActive(true);
                    iBar8.gameObject.SetActive(false);
                    iBar9.gameObject.SetActive(false);
                    iBar10.gameObject.SetActive(false);
                    iBar11.gameObject.SetActive(false);
                    break;
                    case 7:
                    iBar1.gameObject.SetActive(false);
                    iBar2.gameObject.SetActive(false);
                    iBar3.gameObject.SetActive(false);
                    iBar4.gameObject.SetActive(false);
                    iBar5.gameObject.SetActive(false);
                    iBar6.gameObject.SetActive(false);
                    iBar7.gameObject.SetActive(false);
                    iBar8.gameObject.SetActive(true);
                    iBar9.gameObject.SetActive(false);
                    iBar10.gameObject.SetActive(false);
                    iBar11.gameObject.SetActive(false);
                    break;
                    case 8:
                    iBar1.gameObject.SetActive(false);
                    iBar2.gameObject.SetActive(false);
                    iBar3.gameObject.SetActive(false);
                    iBar4.gameObject.SetActive(false);
                    iBar5.gameObject.SetActive(false);
                    iBar6.gameObject.SetActive(false);
                    iBar7.gameObject.SetActive(false);
                    iBar8.gameObject.SetActive(false);
                    iBar9.gameObject.SetActive(true);
                    iBar10.gameObject.SetActive(false);
                    iBar11.gameObject.SetActive(false);
                    break;
                    case 9:
                    iBar1.gameObject.SetActive(false);
                    iBar2.gameObject.SetActive(false);
                    iBar3.gameObject.SetActive(false);
                    iBar4.gameObject.SetActive(false);
                    iBar5.gameObject.SetActive(false);
                    iBar6.gameObject.SetActive(false);
                    iBar7.gameObject.SetActive(false);
                    iBar8.gameObject.SetActive(false);
                    iBar9.gameObject.SetActive(false);
                    iBar10.gameObject.SetActive(true);
                    iBar11.gameObject.SetActive(false);
                    break;
                    case 10:
                    iBar1.gameObject.SetActive(false);
                    iBar2.gameObject.SetActive(false);
                    iBar3.gameObject.SetActive(false);
                    iBar4.gameObject.SetActive(false);
                    iBar5.gameObject.SetActive(false);
                    iBar6.gameObject.SetActive(false);
                    iBar7.gameObject.SetActive(false);
                    iBar8.gameObject.SetActive(false);
                    iBar9.gameObject.SetActive(false);
                    iBar10.gameObject.SetActive(false);
                    iBar11.gameObject.SetActive(true);
                    break;
                }
            }
        
        if (potionCount > 0)
        {
            if (Input.GetKeyDown("e"))
            {
                GameControl.potionCount -= 1;
                GameControl.health +=1;
            }
        }
    }
}