using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] ObjectPoolManager poolManager;
    public GameObject objectToSpawn;

    void Awake()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePosition = Input.mousePosition;
            Vector2 worldMousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

            // Instantiate(objectToSpawn, worldMousePosition, Quaternion.identity);

            GameObject go = poolManager.GetPooledObject();
        
            go.SetActive(true);
            go.transform.position = worldMousePosition;
            Rigidbody2D rb = go.GetComponent<Rigidbody2D>();
            rb.velocity = Vector2.up * 5;

        }
    }

}
