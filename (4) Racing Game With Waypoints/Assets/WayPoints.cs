using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WayPoints : MonoBehaviour
{
    public Transform player;
    public Transform[] wayPoints;         // b =goal

    public int i=0;
    public float speed = 2f;
    public float accuracy = 0.3f;

    // Update is called once per frame
    void LateUpdate()
    {
        
        Vector3 dir = wayPoints[i].position - player.position;
        Vector3 LookAtDir = new Vector3(wayPoints[i].position.x, player.position.y, wayPoints[i].position.z);

        player.Translate(0,0,speed*Time.deltaTime);
        player.LookAt(LookAtDir);
        
        if (dir.magnitude < accuracy)
        {
            i++;
            if (i >= wayPoints.Length)
            {
                i = 0;
            }
        }
    }
}
