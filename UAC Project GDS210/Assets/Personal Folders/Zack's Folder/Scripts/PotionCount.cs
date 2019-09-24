using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionCount : MonoBehaviour
{
    // Add to player Animated left hand, so that when their hand collides with the potion, potion inventory count is increased.

    void OnTriggerEnter(Collider collider)
    {
        GameControl.potionCount += 1;
    }
}