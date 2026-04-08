using UnityEngine;
using TMPro;

public class Menu : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI moneyUI;

    private void OnGUI()
    {
        moneyUI.text = LevelManager.main.currency.ToString();
    }

    public void SetSlected()
    {

    }
}
