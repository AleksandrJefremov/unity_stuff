using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SnakeControl : MonoBehaviour
{
    public float snakeSpeed = 100f;

    public int rotation = 0;

    void Update()
    {

        if (Input.GetKey("up"))
        {
            print("UpArrow key was pressed");
            rotation = 0;
        }

        if (Input.GetKey("down"))
        {
            rotation = 180;
        }

        if (Input.GetKey("left"))
        {
            rotation = 270;
        }

        if (Input.GetKey("right"))
        {
            rotation = 90;
        }

        transform.rotation = Quaternion.AngleAxis(rotation, Vector3.up);
        transform.position += transform.forward * snakeSpeed * Time.deltaTime;

    }
}
