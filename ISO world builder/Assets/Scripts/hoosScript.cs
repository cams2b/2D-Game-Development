﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hoosScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void onTriggerEnter(Collider other)
    {
        if(other.name == "Protagonist")
        {
            Debug.Log("We hit an obstacle");
        }

    }


}
