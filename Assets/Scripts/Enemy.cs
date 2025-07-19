using UnityEngine;

public class Enemy: MonoBehaviour
{
//ATTACK 

    [SerializeField] float attackRange = 2f;
    [SerializeField] int damage = 10;
    [SerializeField] float attackCooldown = 1.0f;

//MOVEMENT

    [SerializeField] float moveSpeed = 3f;
    [SerializeField] string playerTag = "Player";

    private float lastAttackTime;
    private Transform player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag(playerTag)?.transform;
    }

    void Update()
    {
        if (player == null) return;
        float distance = Vector3.Distance(transform.position, player.position);
        if (distance > attackRange)
        {
            Vector3 direction = (player.position - transform.position).normalized;
            transform.position = Vector3.MoveTowards(transform.position, player.position, moveSpeed * Time.deltaTime);

            //FOR WHEN CHARACTER HAS A FACE; 
            Quaternion lookRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
        }

        if (distance <= attackRange && Time.time >= lastAttackTime + attackCooldown)
        {
            PlayerHealth health = player.GetComponent<PlayerHealth>();
            if (health != null)
            {
                health.TakeDamage(damage);
                lastAttackTime = Time.time;
            }
        }
    }
}
