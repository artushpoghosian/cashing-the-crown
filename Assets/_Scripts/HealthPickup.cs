using System.Collections;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    [SerializeField] int healAmount = 5;
    [SerializeField] MeshRenderer meshRenderer;
    [SerializeField] SphereCollider sphereCollider;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<PlayerInfo>().Heal(healAmount);
            ToggleVisibility();
            StartCoroutine(ReappearAfterTime(5f));
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