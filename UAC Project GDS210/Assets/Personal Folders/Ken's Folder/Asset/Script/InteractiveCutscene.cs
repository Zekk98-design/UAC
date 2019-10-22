using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveCutscene : MonoBehaviour
{
    public Animator ani;
    private float cutLength1 = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        // getting the animator from camera 
        ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // when button e is press down play animation
        if (Input.GetKeyDown(KeyCode.Q))
        {
            // sets the bool in animator to true
            ani.SetBool("Qpress", true);
            // playes the animation for the amount of time it's
            Animation1(cutLength1);
            Debug.Log("yeet");
        }
            
        
    }
    // corratie that playes the animation then sets animation to false when done
    IEnumerator Animation1(float animationLength)
    {
        yield return new WaitForSeconds(animationLength);
        ani.SetBool("Qpress", false);
    }
}
