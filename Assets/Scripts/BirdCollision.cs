using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdCollision : Bird
{
    public Bird birdScript;
    private void Start()
    {
        birdScript = GetComponent<Bird>();
    }


    void OnTriggerEnter2D(Collider2D other)
    {
       
        if (other.tag == "Pipeblank")
        {
            IncreaseScore();

        }
        else
        {
            
            GameOver();
        }
    }
}
