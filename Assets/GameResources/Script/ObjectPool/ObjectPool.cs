using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public GameObject objectPrefab;
    public int poolSize;

    private List<GameObject> objectsPool;

    private void Start()
    {
        objectsPool = new List<GameObject>();

    }
    public void CreateObjectToPool()
    {
        //沒特別設定就預設物件池大小10
        poolSize = 10;
        for (int i = 0; i < poolSize; i++)
        {
            GameObject gameObject = Instantiate(objectPrefab);
            gameObject.SetActive(false);
            objectsPool.Add(gameObject);
        }
    }
    public void CreateObjectToPool(int poolSize)
    {
        for (int i = 0; i < poolSize; i++)
        {
            GameObject gameObject = Instantiate(objectPrefab);
            gameObject.SetActive(false);
            objectsPool.Add(gameObject);
        }
    }

    public GameObject GetPooledObject()
    {
        for (int i = 0; i < objectsPool.Count; i++)
        {
            if (!objectsPool[i].activeInHierarchy)
            {
                return objectsPool[i];
            }
        }
        return null;
    }
    public void ReturnToPool(GameObject gameObject)
    {
        gameObject.SetActive(false);
    }

}
