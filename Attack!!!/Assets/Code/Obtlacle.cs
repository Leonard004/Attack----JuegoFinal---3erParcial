using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obtlacle : MonoBehaviour
{
    public float speed;

    void Update()
    {
        transform.Translate(-speed * Time.deltaTime, 0, 0);

        if(transform.position.x < -20f)
        {
            Destroy(gameObject);
        }
    }
}
