using UnityEngine;

public class PlayerAttack: MonoBehaviour
{
    public float attackRange = 2f;
    public int damage = 10;

    void Update()
    {
        if (Input.GetMouseButtonDown(1)) 
        {
            Collider[] hits = Physics.OverlapSphere(transform.position, attackRange);

            foreach (Collider hit in hits)
            {
                if (hit.CompareTag("Enemy"))
                {
                    EnemyHealth health = hit.GetComponent<EnemyHealth>();
                    if (health != null)
                    {
                        health.TakeDamage(damage);
                        break;
                    }
                }
            }
        }
    }
}