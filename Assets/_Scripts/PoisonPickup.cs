using System.Collections;
using UnityEngine;

public class PoisonPickup : MonoBehaviour
{
    [SerializeField] int damageAmount = 15;
    [SerializeField] MeshRenderer meshRenderer;
    [SerializeField] SphereCollider sphereCollider;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<PlayerInfo>().TakeDamage(damageAmount);
            ToggleVisibility();
            StartCoroutine(ReappearAfterTime(4f));
        }
    }

    void ToggleVisibility()
    {
        meshRenderer.enabled = !meshRenderer.enabled;
        sphereCollider.enabled = !sphereCollider.enabled;
    }

    IEnumerator ReappearAfterTime(float cooldown)
    {
        yield return new WaitForSeconds(cooldown);
        ToggleVisibility();
    }
}