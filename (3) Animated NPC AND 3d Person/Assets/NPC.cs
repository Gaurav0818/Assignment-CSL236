using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class NPC : MonoBehaviour
{
    public Transform player;
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
    void LateUpdate()
    {
        speedText.text = speed.ToString();
        accuracyText.text = accuracy.ToString();
        v1.text = player.position.ToString();
        v2.text = b.position.ToString();
        Vector3 dir = b.position - player.position;
        Vector3 LookAtDir = new Vector3(b.position.x - player.position.x, player.position.y, b.position.z - player.position.z);
        directionV12.text = dir.ToString();
        magnitudeDir.text = dir.magnitude.ToString();

        if (dir.magnitude > accuracy)
        {
            player.Translate(dir.normalized * speed * Time.deltaTime);
            player.LookAt(LookAtDir);
        }
    }
}
