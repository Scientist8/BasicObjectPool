using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolManager : MonoBehaviour
{
    [SerializeField] GameObject objectToPool;
    [SerializeField] int poolSize = 10;
    public List<GameObject> objects;
    [SerializeField] Transform poolParent;

    void Start()
    {
        // Populate the object pool
        for (int i = 0; i < poolSize; i++)
        {
            GameObject pooledObject = Instantiate(objectToPool, poolParent);
            pooledObject.SetActive(false);
            objects.Add(pooledObject);
        }
    }

    public GameObject GetPooledObject()
    {
         // Look for an inactive object in the pool
        foreach (GameObject pooledObject in objects)
        {
            if (!pooledObject.activeInHierarchy)
            {
                return pooledObject;
            }
        }

        // If all objects are active, create a new one and add it to the pool
        GameObject newObject = Instantiate(objectToPool, poolParent);
        newObject.SetActive(false);
        objects.Add(newObject);

        return newObject;
    }

    public void ClearAllPooledObjects()
    {
        for (int i = 0; i < objects.Count; i++)
        {
            objects[i].SetActive(false);
        }
    }
}
