using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObject : MonoBehaviour
{
    public float moveSpeed;
    public Transform pointA;
    public Transform pointB;
    bool movingBack;

    // Update is called once per frame
    void Update()
    {
        if (!movingBack && transform.position != pointB.position)
        {
            transform.position = Vector2.MoveTowards(transform.position, pointB.position, moveSpeed * Time.deltaTime);
        }
        else if (movingBack && transform.position != pointA.position)
        {
            transform.position = Vector2.MoveTowards(transform.position, pointA.position, moveSpeed * Time.deltaTime);
        }
        else
        {
            movingBack = !movingBack;
            transform.Rotate(0f, 180f, 0f);
        }
    }
}
