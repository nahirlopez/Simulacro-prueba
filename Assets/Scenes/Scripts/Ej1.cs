﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej1 : MonoBehaviour
{

    // Start is called before the first frame update

    public int num1;
    public int num2;
    void Start()
    {
        if (num1== num2)
        {
            Debug.Log("Son inguales");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
