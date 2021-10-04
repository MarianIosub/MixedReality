using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Fight : MonoBehaviour
{
    public GameObject mushroom1;
    public GameObject mushroom2;
    public bool idle = true;
    public bool fight = false;
    public float distance = 100f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var mushroom1 = this.transform.GetChild(0).GetChild(0);
        var mushroom2 = this.transform.GetChild(1).GetChild(0);
        var position1 = mushroom1.transform.position;
        var position2 = mushroom2.transform.position;


        if (Math.Abs(position1.x - position2.x) < distance)
        {
            fight = true;
            idle = false;
        }
        else if (Math.Abs(position1.x - position2.x) > distance)
        {
            idle = true;
            fight = false;
        }
        if (fight == true)
        {   
            mushroom1.transform.GetComponent<Animation>().CrossFade("Attack");
            mushroom2.transform.GetComponent<Animation>().CrossFade("Attack");
        }
        if (idle == true)
        {
            mushroom1.transform.GetComponent<Animation>().CrossFade("Idle");
            mushroom2.transform.GetComponent<Animation>().CrossFade("Idle");
        }

    }
}
