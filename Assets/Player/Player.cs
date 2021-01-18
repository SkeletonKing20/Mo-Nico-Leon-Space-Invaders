using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float movementSpeed = 5f;
    public Bullet bullet;
    public void movePlayer()
    {
        float fuckYouCase = transform.position.x;
        if(fuckYouCase < -8)
        {
            transform.position = new Vector3(-8f, -4f, 0);
        }
        else if (fuckYouCase > 8)
        {
            transform.position = new Vector3(8f, -4f, 0);
        }
        else
        {
            transform.position += Vector3.right *
            Input.GetAxisRaw("Horizontal") *
            movementSpeed * Time.deltaTime;
        }
          
    }

    public void shoot()
    {
        Instantiate(bullet, this.transform.position, this.transform.rotation);
    }

    public void Update()
    {
        movePlayer();
        if(Input.GetButtonDown("Shoot"))
        {
            shoot();
        }
    }
}
