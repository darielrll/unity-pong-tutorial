using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IA : MonoBehaviour
{
    public float speed = 3;
    public GameObject ball;
    private Vector2 ballPosition;

    void Update()
    {
        Move();
    }

    private void Move()
    {
        ballPosition = ball.transform.position;
        if (transform.position.y > ballPosition.y)
        {
            transform.position += new Vector3(0, -speed * Time.deltaTime, 0);
        }


        if (transform.position.y < ballPosition.y)
        {
            transform.position += new Vector3(0, speed * Time.deltaTime, 0);
        }
    }
}
