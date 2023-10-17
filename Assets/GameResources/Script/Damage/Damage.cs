using UnityEngine;

public class Damage : MonoBehaviour
{
    public GameObject player;
    private PlayerScript playerScript;
    private PlayerData playerData;
    private DamageData damageData;


    private void Start()
    {
        playerScript = FindObjectOfType<PlayerScript>();
        playerData = new PlayerData();
        damageData = new DamageData();
    }

    public void OnCollisionEnter(Collision other)
    {
        if (other == null)
        {
            return;
        }
        if (other.gameObject.name == "Player")
        {
            Debug.Log("����F");
            playerScript.hp -= damageData.common;
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        //�Ĥ@�H�٥i��~�γo��
        if (other == null)
        {
            return;
        }
        if (other.gameObject.name == "Player")
        {
            Debug.Log("����F");
            playerScript.hp -= damageData.common;
        }

    }
}
