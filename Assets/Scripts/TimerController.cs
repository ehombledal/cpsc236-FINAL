using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController: MonoBehaviour
{
    public Text myTimer;
    private float startTime;
    public bool finished;

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time; 
    }

    // Update is called once per frame
    void Update()
    {
        if (finished)
        {
            return;
        }
       

        myTimer.text = "Time: " + Time.timeSinceLevelLoad.ToString(); 
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            finished = true; 
        }
    }
}
