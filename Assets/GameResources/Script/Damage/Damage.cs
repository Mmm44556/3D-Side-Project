using UnityEngine;

public class Damage : MonoBehaviour
{
    public GameObject player = null;
    private PlayerScript playerScript = null;
    private PlayerData playerData;


    private void Start()
    {
        playerScript = FindObjectOfType<PlayerScript>();
        playerData = new PlayerData();
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
            playerScript.hp -= 1;
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
            playerScript.hp -= 1;
        }

    }
}
