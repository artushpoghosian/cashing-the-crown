using System.Collections;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] int coinValue = 1;
    [SerializeField] MeshRenderer meshRenderer;
    [SerializeField] CapsuleCollider capsuleCollider;

    void Update()
    {
        if (meshRenderer.enabled)
        {
            transform.Rotate(0f, 0f, 180f * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<PlayerInfo>().AddCoins(coinValue);
            ToggleVisibility();
            StartCoroutine(ReappearAfterTime(3f));
        }
    }

    void ToggleVisibility()
    {
        meshRenderer.enabled = !meshRenderer.enabled;
        capsuleCollider.enabled = !capsuleCollider.enabled;
    }

    IEnumerator ReappearAfterTime(float cooldown)
    {
        yield return new WaitForSeconds(cooldown);
        ToggleVisibility();
    }
}