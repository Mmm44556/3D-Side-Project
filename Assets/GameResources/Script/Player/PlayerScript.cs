using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    PlayerData playerData;
    public HealthBar healthBar;

    public int hp;
    public int mp;
    private float speed;

    void Start()
    {
        playerData = new PlayerData();
        PlayerDataInit();
    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log("¦å¶q:" + hp);
        healthBar.SetHealth(hp);
    }

    private void PlayerDataInit()
    {
        hp = playerData.healthPoint;
        mp = playerData.manaPoint;
        speed = playerData.speed;
    }

}
