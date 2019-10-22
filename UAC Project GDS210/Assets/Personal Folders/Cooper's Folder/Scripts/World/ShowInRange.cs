using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowInRange : MonoBehaviour
{
    public Transform player;
    public float showOnDistance = 2;
    public GameObject ShowThis;
    public GameObject GeneratorD;

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, player.position) < showOnDistance)
            ShowThis.SetActive(true);
        else
            ShowThis.SetActive(false);

        if (GeneratorD.activeInHierarchy)
        {
            ShowThis.SetActive(false);
        }
    }
}﻿

