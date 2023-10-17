using UnityEngine;

public class Damage : MonoBehaviour
{
    public GameObject player = null;
    private PlayerScript playerScript = null;
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
        //�Ĥ@�H�٤~�γo��
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
