using UnityEngine;

public class Enemy : MonoBehaviour
{
    private EnemySpawner spawner;
    private float speed = 0.2f;
    private float rightBorder = 8;
    private float leftBorder = -8;
    public void MoveEnemy()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;
        foreach (Enemy enemy in spawner.GetSpawnerChildren())
        {
            if (transform.position.x < leftBorder || transform.position.x > rightBorder)
            {
                speed = -speed;
                transform.position += Vector3.down;
                return;
            }
        }
    }
    private void Awake()
    {
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
    public bool isPlayerDed()
    {
        if (this.transform.position.y <= 0.88)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private void OnDestroy()
    {
        spawner.OnBeforeEnemyDestroyed(this);
    }

    public void SetEnemySpawner(EnemySpawner spawner)
    {
        this.spawner = spawner;
    }
}

