using UnityEngine;

public class EnemyHealth: MonoBehaviour
{
    [SerializeField] private int health = 50;

    public void TakeDamage(int amount)
    {
        health = Mathf.Max(health - amount, 0);

        if (health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Destroy(gameObject, 1f);
    }
}

