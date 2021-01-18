using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet: MonoBehaviour
{
    public float movementSpeed = 0.2f;
    Rigidbody2D rb2d;
    void FixedUpdate()
    {
        rb2d.velocity += Vector2.up * movementSpeed * Time.deltaTime;
    }
    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Why"))
        {
            Debug.Log("What");
            Destroy(gameObject);
        }
    }
}
