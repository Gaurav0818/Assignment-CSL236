using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class NPC : MonoBehaviour
{
    public Transform a;
    public Transform b;         // b =goal

    public float speed = 2f;
    public float accuracy = 0.1f;

    public Text v1;
    public Text v2;
    public Text directionV12;
    public Text magnitudeDir;
    public Text speedText;
    public Text accuracyText;

    // Update is called once per frame
    void Update()
    {
        speedText.text = speed.ToString();
        accuracyText.text = accuracy.ToString();
        v1.text = a.position.ToString();
        v2.text = b.position.ToString();
        Vector3 dir = b.position - a.position;
        directionV12.text = dir.ToString();
        magnitudeDir.text = dir.magnitude.ToString();

        if (dir.magnitude > accuracy)
        {
            a.Translate(dir.normalized*speed*Time.deltaTime);
        }
    }
}
