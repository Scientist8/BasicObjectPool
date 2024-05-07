using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectScript : MonoBehaviour
{
    private float timer = 0f;
    public float timeToDestroy = 3f;
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= timeToDestroy)
        {
            timer = 0f;
            this.gameObject.SetActive(false);
        }
    }
}
