using UnityEngine;

public class FinishZone : MonoBehaviour
{
    [SerializeField] private GameEndUI gameEndUI;
    [SerializeField] private int requiredCoins = 15;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
            return;

        PlayerInfo player = other.GetComponent<PlayerInfo>();

        if (player.coins >= requiredCoins)
            gameEndUI.ShowWin(player.coins, requiredCoins);
        else
            gameEndUI.ShowLose(player.coins, requiredCoins);
    }
}