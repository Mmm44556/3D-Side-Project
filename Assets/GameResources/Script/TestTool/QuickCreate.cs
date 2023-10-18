using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuickCreate : MonoBehaviour
{
    public GameObject floorPrefab; // 將石頭地板Prefab分配給這個變數

    public int createHeight = 10; //產生的長寬
    public int createWidth = 10;

    public int prefabHeight = 1;//要填prefab本身的長寬
    public int prefabWidth = 1;
    void Start()
    {
        for (int i = 0; i < createHeight; i++)
        {
            for (int j = 0; j < createWidth; j++)
            {
                // 設置Prefab的位置
                Vector3 position = new Vector3(i * prefabHeight, 0, j * prefabWidth);
                Instantiate(floorPrefab, position, floorPrefab.transform.rotation);
            }
        }
    }
}
