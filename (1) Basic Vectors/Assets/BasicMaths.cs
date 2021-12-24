using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BasicMaths : MonoBehaviour
{
    public Transform a;
    public Transform b;

    public Text v1;
    public Text v2;
    public Text directionV12;
    public Text magnitudeDir;

    // Update is called once per frame
    void Update()
    {
        v1.text = a.position.ToString();
        v2.text = b.position.ToString();
        Vector3 dir = b.position - a.position;
        directionV12.text = dir.ToString();
        magnitudeDir.text = dir.magnitude.ToString();
    }
}
