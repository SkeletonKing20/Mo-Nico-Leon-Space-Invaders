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
    private void FixedUpdate()
    {
        MoveEnemy();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        OnEnemyHit();
    }

    private void OnDestroy()
    {
        spawner.OnBeforeEnemyDestroyed(this);
    }

    public void SetEnemySpawner(EnemySpawner spawner)
    {
        this.spawner = spawner;
    }

    protected virtual void OnEnemyHit()
    {
        Destroy(gameObject);
    }
}

