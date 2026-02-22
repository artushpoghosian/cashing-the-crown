using UnityEngine;
using TMPro;

public class GameEndUI : MonoBehaviour
{
    [SerializeField] private GameObject endScreenPanel;
    [SerializeField] private TextMeshProUGUI titleText;
    [SerializeField] private TextMeshProUGUI messageText;

    public void ShowWin(int collected, int required)
    {
        endScreenPanel.SetActive(true);

        titleText.text = "Princess is SAVED!!!";
        titleText.color = Color.green;

        messageText.text = "You collected " + collected + " / " + required + " coins!";
    }

    public void ShowLose(int collected, int required)
    {
        endScreenPanel.SetActive(true);

        titleText.text = "You lost the princess...";
        titleText.color = Color.red;

        messageText.text = "Only " + collected + " / " + required + " coins collected.";
    }
}