using UnityEngine;

public class DeathZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerInfo playerInfo = other.gameObject.GetComponent<PlayerInfo>();
            playerInfo.TakeDamage(playerInfo.currentHealth);
        }
    }
}