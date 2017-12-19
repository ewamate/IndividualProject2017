using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class gyro : MonoBehaviour
{
    public float speed = 10.0F;

    // Use this for initialization
    void Start()
    {

    }
    void Update()
    {
        Vector3 dir = Vector3.zero;
        dir.x = -Input.acceleration.y;
        dir.z = Input.acceleration.x;
        dir.y = Input.acceleration.z;
        if (dir.sqrMagnitude > 1)
            dir.Normalize();

        dir *= Time.deltaTime;
        transform.Translate(dir * speed);

        GameObject textX = GameObject.Find("TextX");
        textX.GetComponent<Text>().text = dir.z.ToString();

        GameObject textY = GameObject.Find("TextY");
        textY.GetComponent<Text>().text = dir.x.ToString();

        GameObject textZ = GameObject.Find("TextZ");
        textZ.GetComponent<Text>().text = dir.y.ToString();
    }
}
