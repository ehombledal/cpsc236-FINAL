﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        Application.LoadLevel(0);
    }
}