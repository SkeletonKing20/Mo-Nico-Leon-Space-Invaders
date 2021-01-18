using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float movementSpeed = 0.2f;
    Rigidbody2D rb2d;
    void FixedUpdate()
    {
        rb2d.velocity += Vector2.down * movementSpeed * Time.deltaTime;
    }
    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
}
