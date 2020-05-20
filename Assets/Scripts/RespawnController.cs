using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnController : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Application.LoadLevel(0);
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        Application.LoadLevel(0);
    }
}
