using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{

    public float JumpForce = 200f;
    public float forwardSpeed = 2f;
    public bool dead = false;
    Rigidbody2D rb;
    public GameObject cam;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < 52)
        {
            if (!dead)
            {
                if (Input.GetButtonDown("Jump"))
                {
                    rb.velocity = Vector2.zero;
                    rb.AddForce(Vector2.up * JumpForce);
                }
                rb.transform.Translate(new Vector3(1, 0, 0) * forwardSpeed * Time.deltaTime);
                cam.transform.Translate(new Vector3(1, 0, 0) * forwardSpeed * Time.deltaTime);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        dead = true;
    }

}