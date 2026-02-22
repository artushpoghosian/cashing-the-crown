using UnityEngine;
using TMPro;

public class CoinUI : MonoBehaviour
{
    [SerializeField] PlayerInfo playerInfo;
    [SerializeField] TextMeshProUGUI coinText;

    void Update()
    {
        if (playerInfo != null && coinText != null)
        {
            coinText.text = "Coins: " + playerInfo.coins;
        }
    }
}