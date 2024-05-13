using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Players : MonoBehaviour
{
    public bool player1;
    public float speed = 3;
    public Rigidbody2D rb;
    private float move;
    private Vector2 startPos;
    private float moveSpeedTouchControl = 0.05f;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        if (player1)
        {
            if (Input.GetMouseButton(0))
            {
                Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                if (mousePosition.x > 1)
                {
                    if (mousePosition.y > 0.5)
                    {
                        transform.Translate(0, moveSpeedTouchControl, 0);
                    }
                    else if (mousePosition.y < 0.5)
                    {
                        transform.Translate(0, -moveSpeedTouchControl, 0);
                    }
                }
            }
            move = Input.GetAxisRaw("Vertical");
        }
        else
        {
            if (Input.GetMouseButton(0))
            {
                Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                if (mousePosition.x < -1)
                {
                    if (mousePosition.y > 0.5)
                    {
                        transform.Translate(0, moveSpeedTouchControl, 0);
                    }
                    else if (mousePosition.y < 0.5)
                    {
                        transform.Translate(0, -moveSpeedTouchControl, 0);
                    }
                }
            }
            move = Input.GetAxisRaw("Vertical2");
        }

        rb.velocity = new Vector2(rb.velocity.x, move * speed);
    }

    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPos;
    }
}
