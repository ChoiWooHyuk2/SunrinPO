using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D rd;
    public Transform ch;
    private Transform ball;
    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Rigidbody2D>();
        ball = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (ch.position.x > ball.position.x) {

            rd.AddForce(Vector2.left * 0.2f, ForceMode2D.Impulse);
        }
        else if (ch.position.x < ball.position.x)
        {

            rd.AddForce(Vector2.right * 0.2f, ForceMode2D.Impulse);
        }
    }
}
