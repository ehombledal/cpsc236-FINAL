﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeSetter : MonoBehaviour
{
    public SpiderRope[] rope;
    private int index = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Vector2 worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            rope[index].setStart(worldPos);
            index++;
            if (index > rope.Length - 1)
            {
                index = 0; 
            }
        }
    }
}
