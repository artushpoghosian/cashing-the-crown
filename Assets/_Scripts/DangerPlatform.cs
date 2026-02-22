using UnityEngine;

public class DangerPlatform : MonoBehaviour
{
    [SerializeField] int damageAmount = 10;
    private float damageInterval = 1f;
    private float lastDamageTime = 0f;

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (Time.time >= lastDamageTime + damageInterval)
            {
                collision.gameObject.GetComponent<PlayerInfo>().TakeDamage(damageAmount);
                lastDamageTime = Time.time;
            }
        }
    }
}