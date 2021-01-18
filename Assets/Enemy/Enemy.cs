using UnityEngine;

public class Enemy : MonoBehaviour
{
    private EnemySpawner spawner;
    public Bullet EnemyBullet;
    private float initialRocketChance = 0.012f;
    private float chance;
    private static int enemiesDestroyed = 0;
    public float fucktor = 0.042f;
    private void FixedUpdate()
    {
        spawnRocket();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Destroy(gameObject);
            enemiesDestroyed++;
            Destroy(collision.gameObject);
            Debug.Log(rocketChanceCalc());
        }
    }

    public float rocketChanceCalc()
    {
        float rocketChance = fucktor * enemiesDestroyed + 0.012f;
        return rocketChance;
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

    public void spawnRocket()
    {
        chance = Random.Range(0, 100f);
        if(chance <= rocketChanceCalc())
        {
            Instantiate(EnemyBullet, transform.position, Quaternion.AngleAxis(180, Vector3.right));
        }
    }
}

