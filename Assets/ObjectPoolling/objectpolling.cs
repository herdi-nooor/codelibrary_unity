using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectpolling : MonoBehaviour
{
    public static objectpolling SharedInstance;

    public List<GameObject> pooledObject;
    public GameObject objectToPooled;
    public int amountToPool;

    private void Awake() {
        SharedInstance = this;
    }

    private void Start() {
        pooledObject = new List<GameObject>();
        for (int i = 0; i < amountToPool; i++)
        {
            GameObject obj = (GameObject)Instantiate(objectToPooled);
            obj.SetActive(false);
            pooledObject.Add(obj);
        }
    }

    public GameObject GetPooledObject(){
        for (int i = 0; i < pooledObject.Count; i++)
        {
            if (!pooledObject[i].activeInHierarchy)
            {
                return pooledObject[i];
            }
        }
        return null;
    }

    // object to spawn position and rotation
    GameObject spawner;
    public void classCallingPolingObject()
    {
        // this to get object in pooledObject
        // this to save object from object pooling
        GameObject objects = ObjectPooler.SharedInstance.GetPooledObject();
        // loop to check object
        if (objects != null)
        {
            objects.transform.position = spawner.transform.psition;
            objects.transform.rotation = spawner.transform.rotation;
            objects.SetActive(true);
        }

        //to destroy
        objects.SetActive(false);
        // orthis
        if (objects.gameObject.tag = "destroyer")
        {
            if (gameObject.tag == "objectsInPolled")
            {
                gameObject.SetActive(false);
            } else {
                Destroy(gameObject);
            }
        }
    }
    ////////////////////////////////////////////////////////////////////////////
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
            return false;
        }
    }
}
