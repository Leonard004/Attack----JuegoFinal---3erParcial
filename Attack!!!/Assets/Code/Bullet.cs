using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody2D rb;
    public GameObject atack;
    public GameObject burst;
    public float Speed;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb.velocity = new Vector2(+Speed, 0);
        Destroy(gameObject, 5f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            GameObject clonEx = Instantiate(burst, transform.position, transform.rotation);
            Destroy(clonEx, 0.5f);

            Destroy(collision.gameObject);
            Destroy(atack);
        }
     }
}
