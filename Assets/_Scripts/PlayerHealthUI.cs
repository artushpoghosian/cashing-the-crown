using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthUI : MonoBehaviour
{
    [SerializeField] PlayerInfo playerInfo;
    [SerializeField] Slider healthSlider;

    void Start()
    {
        if (playerInfo != null && healthSlider != null)
        {
            healthSlider.maxValue = playerInfo.maxHealth;
            healthSlider.value = playerInfo.currentHealth;
        }
    }

    void Update()
    {
        if (playerInfo != null && healthSlider != null)
        {
            healthSlider.value = playerInfo.currentHealth;
        }
    }
}
