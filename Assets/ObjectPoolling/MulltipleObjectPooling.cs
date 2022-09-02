using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MulltipleObjectPooling : MonoBehaviour
{
    ///////////////////////////////////////////////////////////////////////////
    //// this to pooledObject with multitype object to pooling

    //  make this in diferent script
    // [System.serializable]
    // public class ObjectPooItem {
    //    public int amountToPool;
    //    public GameObject objectToPool;
    //    public bool shoulsExpand;
    // }
    
    //public List<ObjectPooItem> itemToPool;
    public List<GameObject> pooledObjects;

    private void Start() {
        pooledObjects = new List<GameObject>();
        foreach (ObjectPoolItem item in itemToPool)
        {
            for (int i = 0; i < item.amountToPool; i++)
            {
                GameObject obj = (GameObject)Instantiate(item.objectToPool);
                obj.SetActive(false);
                pooledObjects.Add(obj);
            }
        }
    }

    public GameObject GetPooledObject(string tag){
        for (int i = 0; i < pooledObjects.Count; i++)
        {
            if (!pooledObjects[i].activeInHierarchy && pooledObjects[i].tag == tag)
            {
                return pooledObjects[i];
            }
        }
        foreach (ObjectPoolItem item in itemToPool)
        {
            if (item.objectToPool.tag == tag)
            {
                if (item.shouldExpand)
                {
                    GameObject obj = (GameObject)Instantiate(objectToPooled);
                    obj.SetActive(false);
                    pooledObject.Add(obj);
                    return obj;
                }
            }
        }
        return null;
    }

    // this code in script controoler object
    private void SpawnInController() 
    {
        GameObject bullet = ObjectPooler.SharedInstance.GetPooledObject("playerbullet")

    }

    ///////
    /// di inspector ubah
    // > item To Pool
    //      size                [             ]
    //      v Element 0
    //          Object To Pool  [ playerBullet]
    //          Amount To Pool  [ 20          ]
    //          Should Expand   [V]
    // > PooledObject
    /// menjadi seperti ini
    // > item To Pool
    //      size                [             ]
    //      v Element 0
    //          Object To Pool  [ playerBullet]
    //          Amount To Pool  [ 20          ]
    //          Should Expand   [V]
    //      v Element 0
    //          Object To Pool  [ enemyDrone1 ]
    //          Amount To Pool  [ 20          ]
    //          Should Expand   [V]
    //      v Element 0
    //          Object To Pool  [ enemyDrone2 ]
    //          Amount To Pool  [ 20          ]
    //          Should Expand   [V]
    // > PooledObject

    //// di script yang mengendalikan gelombang serangan(ext.Dronecontroller)
    //
    //GameObject enemy1 = ObjectPooler.SharedInstance.GetPooledObject("Enemy1");
    //if (enemy1 != null)
    //{
    //    enemy1.transform.position = spawnPosition;
    //    enemy1.transform.rotation = spawnRotetion;
    //    enemy1.SetActive(true);
    //}

    //// untuk men destroy nya di controller  
    //
    // gameObject.SetActive(false);
}
