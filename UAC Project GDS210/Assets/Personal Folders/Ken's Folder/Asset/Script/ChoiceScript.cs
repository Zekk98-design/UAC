using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoiceScript : MonoBehaviour
{
    //Variables
    public GameObject Textbox;
    public GameObject Choice01;
    public GameObject Choice02;
    public GameObject Choice03;
    public int ChoiceMade;

    
    public void ChoiceOption1()
    {
        Textbox.GetComponent<Text>().text = "That's good stranger. Looks like you made the first choice.";
        ChoiceMade = 1;
    }

    public void ChoiceOption2()
    {
        Textbox.GetComponent<Text>().text = "I'm still a stranger too. Looks like you chose the second choice.";
        ChoiceMade = 2;
    }

    public void ChoiceOption3()
    {
        Textbox.GetComponent<Text>().text = "Good for you stranger. Looks like you've made the last choice.";
        ChoiceMade = 3;
    }
    // Update is called once per frame
    void Update()
    {
        if (ChoiceMade >= 1)
        {
            Choice01.SetActive(false);  
            Choice02.SetActive(false);
            Choice03.SetActive(false);
        }
    }
}
