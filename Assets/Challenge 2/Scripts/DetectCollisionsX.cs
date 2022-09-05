using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{
    
    private ScoreDisplayX scoreDisplayX;
    
    public void Start()
    {
        scoreDisplayX = GameObject.Find("ScoreText").GetComponent<ScoreDisplayX>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        scoreDisplayX.score++;
    }
}
