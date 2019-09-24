using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthLoss : MonoBehaviour
{
    // Add to boss weapon, so that when it collides with the player, the player will lose Health.

    void OnTriggerEnter(Collider collider)
    {
        GameControl.health -= 1;
    }
}