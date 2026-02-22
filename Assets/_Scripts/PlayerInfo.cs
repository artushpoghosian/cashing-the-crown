using UnityEngine;

public class PlayerInfo : MonoBehaviour
{
    [SerializeField] public int coins = 0;
    [SerializeField] public int maxHealth = 100;
    [SerializeField] public int currentHealth;
    
    Vector3 startPosition;

    void Start()
    {
        currentHealth = maxHealth;
        startPosition = transform.position;
    }

    void Update()
    {
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    public void AddCoins(int amount)
    {
        coins += amount;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
    }

    public void Heal(int amount)
    {
        currentHealth += amount;
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
    }

    void Die()
    {
        currentHealth = maxHealth;
        coins = 0;
        transform.position = startPosition;
        
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.linearVelocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
    }
}