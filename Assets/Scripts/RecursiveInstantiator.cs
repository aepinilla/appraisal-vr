﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecursiveInstantiator : MonoBehaviour
{
    public int recurse = 5;
    public int splitNumber = 2;

    // Start is called before the first frame update
    void Start()
    {
        recurse -= 1;
        for (int i = 0; i < splitNumber; i++)
        {
            if (recurse > 0)
            {
                var copy = Instantiate(gameObject);
                var recursive = copy.GetComponent<RecursiveInstantiator>();
                recursive.SendMessage("Generated", i);
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
