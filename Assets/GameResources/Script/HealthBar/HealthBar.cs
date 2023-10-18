using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider healthBar;
    PlayerData playerData;
    private void Start()
    {
        healthBar = GetComponent<Slider>();
        playerData = new PlayerData();
        healthBar.maxValue = playerData.healthPoint;
        healthBar.value = playerData.healthPoint;
    }

    public void SetHealth(int hp)
    {
        healthBar.value = hp;
    }
}

