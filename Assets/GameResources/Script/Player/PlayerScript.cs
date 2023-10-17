using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    PlayerData playerData;
    public int hp;
    public int mp;
    private float speed;
    void Start()
    {
        playerData = new PlayerData();
        UpdatePlayerData();
    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log("¦å¶q:" + hp);
    }

    private void UpdatePlayerData()
    {
        hp = playerData.healthPoint;
        mp = playerData.manaPoint;
        speed = playerData.speed;
    }

}
