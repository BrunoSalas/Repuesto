﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroduccionPlanta2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //FindObjectOfType<AudioManager>.pla
            FindObjectOfType<AudioManager>().Play("IntroduccionPlanta2Audio");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            FindObjectOfType<AudioManager>().Pause("IntroduccionPlanta2Audio");

        }
    }
}
