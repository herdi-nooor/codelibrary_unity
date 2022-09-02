using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class incraseObjectPOoling : MonoBehaviour
{
    /////////////////////////////////////////////////////////////////////////////
    /// this if you need to incrase amount of objectpooling in runtime condition
    public bool shoulsExpand = true;
    public GameObject GetPooledObjectExpand(){
        for (int i = 0; i < pooledObject.Count; i++)
        {
            if (!pooledObject[i].activeInHierarchy)
            {
                return pooledObject[i];
            }
        }
        if (shoulsExpand)
        {
            GameObject obj = (GameObject)Instantiate(objectToPooled);
            obj.SetActive(false);
            pooledObject.Add(obj);
            return obj;
        }
        else
        {
            return null;
        }
    }
}
