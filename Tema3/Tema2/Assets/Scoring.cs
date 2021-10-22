using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoring : MonoBehaviour
{
    public GameObject ball;

    public GameObject bucket;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CheckScore()
    {
        Collider ballCollider = ball.GetComponent<Collider>();
        List<Collider> bucketColliders = new List<Collider>(bucket.GetComponents<Collider>());
    }


}
